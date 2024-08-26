using ComponentFactory.Krypton.Toolkit;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class InfoPanel : UserControl
    {
        private DatabaseConnection dbConnection;
        private bool ifDisplay = false;
        public string organName = "a";

        public InfoPanel(int donorId, int organId)
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection();
            LoadOrganAndDonorInfo(donorId, organId);
            LoadAndDisplayTags(donorId, organId);
            AdjustInitialHeight();
        }

        private void AdjustInitialHeight()
        {
            if (!displayPanel.Visible)
            {
                this.Height -= displayPanel.Height;
                this.OnSizeChanged(EventArgs.Empty);
            }
        }

        private void LoadOrganAndDonorInfo(int donorId, int organId)
        {
            try
            {
                string organQuery = @"
                    SELECT 
                        organname.organ_name, 
                        donor.date_of_death, 
                        donor.age, 
                        donor.cause_of_death 
                    FROM 
                        organ 
                    INNER JOIN 
                        organname ON organ.organ_name_id = organname.organ_name_id 
                    INNER JOIN 
                        donor ON organ.donor_id = donor.donor_id 
                    WHERE 
                        organ.organ_id = @organId AND 
                        organ.donor_id = @donorId";

                var parameters = new Dictionary<string, object>
                {
                    { "@organId", organId },
                    { "@donorId", donorId }
                };

                using (var reader = dbConnection.ExecuteReader(organQuery, parameters))
                {
                    if (reader.Read())
                    {
                        string organName = reader.GetString(0);
                        this.organName = organName;

                        DateTime dateOfDeath = reader.GetDateTime(1);
                        int age = reader.GetInt32(2);
                        string causeOfDeath = reader.GetString(3);

                        organNameLabel.Text = organName;
                        donorIdLabel.Text = $"Donor ID: {donorId}";
                        DoDLabel.Text = $"Date of Death: {dateOfDeath.ToString("yyyy-MM-dd")}";
                        ageLabel.Text = $"Age: {age}";
                        CoDLabel.Text = $"Cause of Death: {causeOfDeath}";
                    }
                    else
                    {
                        MessageBox.Show("No data found for the specified donor and organ.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message);
            }
        }

        private void LoadAndDisplayTags(int donorId, int organId)
        {
            List<string> tags = LoadTags(donorId, organId);

            if (tags.Count == 1)
            {
                tagLabel.Text = tags[0];
                AdjustTextBoxSize(tagLabel);
            }
            else if (tags.Count > 1)
            {
                tagLabel.Text = tags[0];
                AdjustTextBoxSize(tagLabel);

                for (int i = 1; i < tags.Count; i++)
                {
                    KryptonTextBox newTagTextBox = CopyKryptonTextBox(tagLabel);
                    newTagTextBox.Text = tags[i];
                    AdjustTextBoxSize(newTagTextBox);
                    tagPanel.Controls.Add(newTagTextBox);
                }
            }
            AdjustTagPanelHeight();
        }

        private void AdjustTagPanelHeight()
        {
            int totalHeight = 0;
            int rowHeight = 0;
            int currentWidth = 0;

            foreach (Control ctrl in tagPanel.Controls)
            {
                if (currentWidth + ctrl.Width > tagPanel.ClientSize.Width)
                {
                    totalHeight += rowHeight; // 累加上一行的高度
                    rowHeight = ctrl.Height;  // 重置当前行的高度为新控件的高度
                    currentWidth = ctrl.Width; // 新行的初始宽度为当前控件的宽度
                }
                else
                {
                    // 当前行可以放下控件，更新当前行的宽度和高度
                    currentWidth += ctrl.Width;
                    rowHeight = Math.Max(rowHeight, ctrl.Height); // 当前行的高度是控件中最高的一个
                }
            }

            totalHeight += rowHeight;

            tagPanel.Height = totalHeight + 15;
        }


        private KryptonTextBox CopyKryptonTextBox(KryptonTextBox original)
        {
            KryptonTextBox copy = new KryptonTextBox
            {
                Text = original.Text,
                Size = original.Size,
                Location = original.Location,
                ReadOnly = original.ReadOnly,
                Multiline = original.Multiline,
                TextAlign = original.TextAlign,
                MaxLength = original.MaxLength,
                Enabled = original.Enabled,
                UseSystemPasswordChar = original.UseSystemPasswordChar,
                Visible = true,
            };

            // StateCommon
            copy.StateCommon.Back.Color1 = original.StateCommon.Back.Color1;
            copy.StateCommon.Border.Color1 = original.StateCommon.Border.Color1;
            copy.StateCommon.Border.Color2 = original.StateCommon.Border.Color2;
            copy.StateCommon.Border.Rounding = original.StateCommon.Border.Rounding;
            copy.StateCommon.Border.Width = original.StateCommon.Border.Width;
            copy.StateCommon.Content.Color1 = original.StateCommon.Content.Color1;
            copy.StateCommon.Content.Font = original.StateCommon.Content.Font;

            // StateActive
            copy.StateActive.Back.Color1 = original.StateActive.Back.Color1;
            copy.StateActive.Border.Color1 = original.StateActive.Border.Color1;
            copy.StateActive.Border.Color2 = original.StateActive.Border.Color2;
            copy.StateActive.Border.Rounding = original.StateActive.Border.Rounding;
            copy.StateActive.Border.Width = original.StateActive.Border.Width;
            copy.StateActive.Content.Color1 = original.StateActive.Content.Color1;
            copy.StateActive.Content.Font = original.StateActive.Content.Font;

            // StateDisabled
            copy.StateDisabled.Back.Color1 = original.StateDisabled.Back.Color1;
            copy.StateDisabled.Border.Color1 = original.StateDisabled.Border.Color1;
            copy.StateDisabled.Border.Color2 = original.StateDisabled.Border.Color2;
            copy.StateDisabled.Border.Rounding = original.StateDisabled.Border.Rounding;
            copy.StateDisabled.Border.Width = original.StateDisabled.Border.Width;
            copy.StateDisabled.Content.Color1 = original.StateDisabled.Content.Color1;
            copy.StateDisabled.Content.Font = original.StateDisabled.Content.Font;

            // StateNormal
            copy.StateNormal.Back.Color1 = original.StateNormal.Back.Color1;
            copy.StateNormal.Border.Color1 = original.StateNormal.Border.Color1;
            copy.StateNormal.Border.Color2 = original.StateNormal.Border.Color2;
            copy.StateNormal.Border.Rounding = original.StateNormal.Border.Rounding;
            copy.StateNormal.Border.Width = original.StateNormal.Border.Width;
            copy.StateNormal.Content.Color1 = original.StateNormal.Content.Color1;
            copy.StateNormal.Content.Font = original.StateNormal.Content.Font;

            return copy;
        }

        private void AdjustTextBoxSize(KryptonTextBox textBox)
        {
            Size textSize = TextRenderer.MeasureText(textBox.Text, textBox.Font);
            textBox.Size = new Size(textSize.Width + 10, textBox.Height);
        }

        private List<string> LoadTags(int donorId, int organId)
        {
            List<string> tags = new List<string>();

            try
            {
                string tagQuery = @"
                    SELECT tag.tag_name
                    FROM organtag
                    INNER JOIN tag ON organtag.tag_id = tag.tag_id
                    WHERE organtag.organ_id = @organId";

                var parameters = new Dictionary<string, object>
                {
                    { "@donorId", donorId },
                    { "@organId", organId }
                };

                using (var reader = dbConnection.ExecuteReader(tagQuery, parameters))
                {
                    while (reader.Read())
                    {
                        tags.Add(reader.GetString(0));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading tags: " + ex.Message);
            }

            return tags;
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            ifDisplay = !ifDisplay;

            displayPanel.Visible = ifDisplay;

            if (descriptionLabel.Text != "No description yet")
            {
                descriptionPanel.Visible = ifDisplay;

                if (!ifDisplay)
                {
                    this.Height -= displayPanel.Height + descriptionPanel.Height;
                }
            }
            else
            {
                descriptionPanel.Visible = false;

                if (!ifDisplay)
                {
                    this.Height -= displayPanel.Height;
                }
            }

            this.OnSizeChanged(EventArgs.Empty);


            btnResize.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            btnResize.Refresh();
        }

        public void CollapsePanels()
        {
            if (ifDisplay == true)
            {
                ifDisplay = false;

                displayPanel.Visible = false;
                descriptionPanel.Visible = false;

                this.Height -= (displayPanel.Height + descriptionPanel.Height);
                btnResize.Image.RotateFlip(RotateFlipType.Rotate180FlipNone);
            }
            this.OnSizeChanged(EventArgs.Empty);
        }


        public void SetDescription(string description)
        {
            descriptionLabel.Text = description;
        }
    }
}