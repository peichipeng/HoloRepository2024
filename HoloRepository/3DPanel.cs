using HoloRepository.AddCase;
using HoloRepository.ContextMenu;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository
{
    public partial class _3DPanel : UserControl
    {
        private int organId;
        private int donorId;
        private string organName;
        private List<string> organSlices;
        private int imageShown;
        private DatabaseConnection dbConnection;
        public int BorderRadius { get; set; } = 2;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderThickness { get; set; } = 1;
        public _3DPanel(int organId, int donorId, List<string> organSlices)
        {
            InitializeComponent();

            this.organId = organId;
            this.donorId = donorId;
            this.organSlices = organSlices;
            this.dbConnection = new DatabaseConnection();

            contextMenu.Renderer = new MenuRenderer();

            setOrganPanel();
        }

        private void setOrganPanel()
        {
            organName = GetOrganName(donorId, organId);
            organNameLabel.Text = $"{donorId}-{organName}";
            organNameLabel.Location = new Point(this.Width / 2 - organNameLabel.Width / 2, 130);
            downArrow.Location = new Point(organNameLabel.Location.X + organNameLabel.Width - 2, 130);

            try
            {
                if (organSlices.Count > 0) // need to add some text if there are no images available
                {
                    placeholderLabel.Visible = false;
                    // Load the image from file path
                    Image image = Image.FromFile(organSlices[0]);

                    // Assign the loaded image to PictureBox
                    sliceImages.Image = image;
                    imageShown = 0;
                }
                else
                {
                    sliceImages.Image = null;
                    placeholderLabel.Visible = true;
                    placeholderLabel.Location = new Point(
                        sliceImages.Location.X + (sliceImages.Width - placeholderLabel.Width) / 2,
                        sliceImages.Location.Y + (sliceImages.Height - placeholderLabel.Height) / 2
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
                // Optionally handle the exception here
            }
        }

        private string GetOrganName(int donorId, int organId)
        {
            string organName = string.Empty;

            try
            {
                string organQuery = "SELECT organ_name FROM organ o JOIN organname on o.organ_name_id = organname.organ_name_id WHERE o.donor_id = @donorId AND o.organ_id = @organId";
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(organQuery, connection))
                {
                    command.Parameters.AddWithValue("@donorId", donorId);
                    command.Parameters.AddWithValue("@organId", organId);

                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        organName = result.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Organ name not found.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving organ name: " + ex.Message);
            }

            return organName;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(0.5f, 0.5f, this.Width - 1, this.Height - 1);

            using (GraphicsPath pathSurface = GetRoundedRectanglePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, BorderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, BorderThickness))
            using (Pen penBorder = new Pen(BorderColor, BorderThickness))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);
                graphics.DrawPath(penSurface, pathSurface);
                graphics.DrawPath(penBorder, pathBorder);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();

            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90); // starting at 180 degree angle with the range of travel of 90 degrees
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);

            path.CloseFigure();
            return path;
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var mainForm = GetMainForm(this);

                if (mainForm != null)
                {
                    var addCaseControl = new AddOrganControl(donorId, organId);

                    mainForm.LoadControl(addCaseControl);

                    addCaseControl.OnSaveCompleted = (id) =>
                    {
                        mainForm.LoadControl(new OrganArchiveControl());
                    };

                    addCaseControl.Dock = DockStyle.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error occurs when clicking update：{ex.Message}");
            }
        }


        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                if (imageShown == 0)
                {
                    imageShown = organSlices.Count - 1;
                }
                else
                {
                    imageShown = imageShown - 1;
                }
                Image image = Image.FromFile(organSlices[imageShown]);
                sliceImages.Image = image;
            }
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                if (imageShown == organSlices.Count - 1)
                {
                    imageShown = 0;
                }
                else
                {
                    imageShown = imageShown + 1;
                }
                Image image = Image.FromFile(organSlices[imageShown]);
                sliceImages.Image = image;
            }
        }

        private void organNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenu.Show(organNameLabel, e.Location);
        }

        private void downArrow_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenu.Show(downArrow, e.Location);
        }

        // The button for deleting the organ
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var popup = new PopupWindow("Are you sure you want to delete?", this.ParentForm))
            {
                var result = popup.ShowDialog(this.ParentForm);

                if (result == DialogResult.Yes)
                {
                    this.Parent.Controls.Remove(this);

                    // Code for deleting the organ
                    var dbConnection = new DatabaseConnection();

                    try
                    {
                        // 查询 organ_side 信息
                        string organSideQuery = "SELECT organ_side FROM organ WHERE organ_id = @organId";
                        string organSide = string.Empty;

                        using (var connection = dbConnection.GetConnection())
                        using (var command = new NpgsqlCommand(organSideQuery, connection))
                        {
                            command.Parameters.AddWithValue("@organId", organId);
                            var resultSide = command.ExecuteScalar();
                            organSide = resultSide != null ? resultSide.ToString() : null;
                        }

                        string deleteQuery = @"
                            DELETE FROM dicomfile WHERE organ_id = @organId;
                            DELETE FROM model3d WHERE organ_id = @organId;
                            DELETE FROM sliceimage WHERE organ_id = @organId;
                            DELETE FROM organtag WHERE organ_id = @organId;
                            DELETE FROM organ WHERE organ_id = @organId;";

                        using (var connection = dbConnection.GetConnection())
                        using (var command = new NpgsqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@organId", organId);
                            command.ExecuteNonQuery();
                        }

                        string organNameWithSide = string.IsNullOrEmpty(organSide) ? organName : $"{organName}({organSide})";
                        string folderPath = Path.Combine("data", donorId.ToString(), organNameWithSide);
                        if (Directory.Exists(folderPath))
                        {
                            Directory.Delete(folderPath, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting organ: " + ex.Message);
                    }
                }
            }
        }

        private MainForm GetMainForm(Control control)
        {
            Control current = control;
            while (current != null)
            {
                if (current is MainForm)
                {
                    return (MainForm)current;
                }
                current = current.Parent;
            }
            return null;
        }


        public string GetDonorId()
        {
            string DonorID = donorId.ToString();
            return DonorID;
        }

        private void sliceImages_Click(object sender, EventArgs e)
        {
            MainInterFaceControl mainInterfaceControl = new MainInterFaceControl(this, donorId, organId);

            MainForm mainForm = GetMainForm(this);

            if (mainForm != null)
            {
                mainForm.Controls.Clear();
                mainForm.Controls.Add(mainInterfaceControl);

                mainInterfaceControl.Dock = DockStyle.Fill;
            }
        }
    }
}
