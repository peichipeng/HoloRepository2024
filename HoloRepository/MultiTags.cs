using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace HoloRepository
{
    public partial class MultiTags : UserControl
    {
        private TextBox textBox;
        private ListBox listBox;
        private FlowLayoutPanel selectedPanel;
        private List<string> data;

        private Dictionary<string, int> tagDictionary;

        public List<int> SelectedTagIds { get; private set; }
        private DatabaseConnection dbConnection;

        private string placeholderText = "Add tags";


        public MultiTags()
        {
            InitializeComponent();
            InitializeControls();

            selectedPanel.Size = this.Size;
            this.Resize += MultiTags_Resize;
        }

        private void MultiTags_Resize(object sender, EventArgs e)
        {
            selectedPanel.Size = this.Size;
        }


        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.selectedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new Point(0, 0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new Size(150, 20);
            this.textBox.TabIndex = 0;
            this.textBox.Margin = new Padding(5, 10, 5, 10);
            this.textBox.ForeColor = Color.Gray;
            this.textBox.TextChanged += new EventHandler(this.TextBox_TextChanged);
            this.textBox.Click += new EventHandler(this.TextBox_Click);
            this.textBox.Text = placeholderText;
            this.textBox.ForeColor = Color.Gray;
            this.textBox.Enter += new EventHandler(this.TextBox_Enter);
            this.textBox.Leave += new EventHandler(this.TextBox_Leave);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(0, this.textBox.Bottom + 2);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(150, 95);
            this.listBox.TabIndex = 1;
            this.listBox.Visible = false;
            this.listBox.Click += new System.EventHandler(this.ListBox_Click);
            // 
            // selectedPanel
            // 
            this.selectedPanel.Location = new System.Drawing.Point(9, 0);
            this.selectedPanel.Name = "selectedPanel";
            this.selectedPanel.TabIndex = 2;
            this.selectedPanel.Controls.Add(this.textBox);
            // 
            // MultiTags
            // 
            this.Controls.Add(this.selectedPanel);
            this.Controls.Add(this.listBox);
            this.Name = "MultiTags";
            this.ResumeLayout(false);
            this.PerformLayout();

            dbConnection = new DatabaseConnection();
        }

        private void TextBox_Click(object sender, EventArgs e)
        {
            ShowListBox();
        }

        private void InitializeControls()
        {
            SelectedTagIds = new List<int>();
            data = new List<string>();
            tagDictionary = new Dictionary<string, int>();

            LoadTagData();
        }

        private void LoadTagData()
        {
            try
            {
                string sql = "SELECT tag_id, tag_name FROM tag";
                using (NpgsqlDataReader reader = dbConnection.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        int id = reader.GetInt32(0);
                        string tagName = reader.GetString(1);
                        data.Add(tagName);
                        tagDictionary[tagName] = id;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        }


        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            // Skip processing if placeholder text is present
            if (textBox.Text == placeholderText)
                return;

            string query = textBox.Text.ToLower();
            var filteredData = data.Where(d => d.ToLower().Contains(query) && !SelectedTagIds.Contains(tagDictionary[d])).ToList();
            listBox.Items.Clear();
            listBox.Items.AddRange(filteredData.ToArray());
            listBox.Visible = filteredData.Any() || string.IsNullOrEmpty(query);

            if (string.IsNullOrEmpty(query))
            {
                listBox.Items.Clear();
                listBox.Items.AddRange(data.Where(d => !SelectedTagIds.Contains(tagDictionary[d])).ToArray());
                listBox.Visible = true;
            }
        }

        private void ListBox_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                AddTag(listBox.SelectedItem.ToString());
                listBox.Items.Remove(listBox.SelectedItem);
                listBox.Visible = false;
                textBox.Clear();
            }
        }

        private void AddTag(string tag)
        {
            SelectedTagIds.Add(tagDictionary[tag]);

            var tagLabel = new Label
            {
                Text = tag,
                AutoSize = true,
                BackColor = Color.Transparent,
                Margin = new Padding(2),
                Padding = new Padding(5)
            };

            var closeButton = new Button
            {
                Text = "X",
                AutoSize = false,
                Size = new Size(20, 27),
                Margin = new Padding(0,2,2,2),
                Padding = new Padding(0),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = {
                    BorderSize = 0,
                    MouseDownBackColor = Color.Transparent,
                    MouseOverBackColor = Color.Transparent
                },
                Tag = tag,
                Font = new Font(Font.FontFamily, Font.Size, FontStyle.Bold)
            };
            closeButton.Click += (s, e) => RemoveTag(s);

            var tagPanel = new FlowLayoutPanel
            {
                AutoSize = true,
                Margin = new Padding(5),
                Padding = new Padding(0),
                BackColor = Color.FromArgb(230, 244, 255),
                BorderStyle = BorderStyle.FixedSingle
            };
            tagPanel.Controls.Add(tagLabel);
            tagPanel.Controls.Add(closeButton);

            selectedPanel.Controls.Add(tagPanel);

            selectedPanel.Controls.Add(textBox);


            ArrangeTextBox();
        }

        private void RemoveTag(object sender)
        {
            var button = sender as Button;
            var tag = button.Tag.ToString();
            SelectedTagIds.Remove(tagDictionary[tag]);

            var tagPanel = button.Parent as FlowLayoutPanel;
            selectedPanel.Controls.Remove(tagPanel);

            ArrangeTextBox();
        }

        private void ShowListBox()
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(data.Where(d => !SelectedTagIds.Contains(tagDictionary[d])).ToArray());

            // Adjust the location of listBox
            listBox.Location = new Point(textBox.Location.X + 9, textBox.Location.Y + textBox.Height + 2);

            listBox.BringToFront();

            listBox.Visible = true;
        }


        private void ArrangeTextBox()
        {
            // Find the position of the last tag and arrange textBox is behind it
            var lastTagPanel = selectedPanel.Controls.OfType<FlowLayoutPanel>().LastOrDefault();
            if (lastTagPanel != null)
            {
                textBox.Location = new Point(lastTagPanel.Location.X + lastTagPanel.Width + 2, lastTagPanel.Location.Y);
            }
            else
            {
                // If no option available, put the textBox at first
                textBox.Location = new Point(3, 3);
            }
        }

        public void AddSelectedTagId(int tagId)
        {
            if (!SelectedTagIds.Contains(tagId))
            {
                var tagName = tagDictionary.FirstOrDefault(x => x.Value == tagId).Key;
                if (!string.IsNullOrEmpty(tagName))
                {
                    AddTag(tagName);
                }
            }
        }


    }
}
