using HoloRepository.ContextMenu;
using HoloRepository.ViewCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoloRepository.AddCase
{
    public partial class OrganPanel : UserControl
    {
        private int organId;
        private string organName;
        private List<string> organSlices;
        private string organModel;
        private int imageShown;
        private DatabaseConnection dbConnection;
        public int BorderRadius { get; set; } = 20;
        public Color BorderColor { get; set; } = Color.LightGray;
        public int BorderThickness { get; set; } = 1;
        public OrganPanel(int organId, string name, List<string> organSlices)
        {
            dbConnection = new DatabaseConnection();
            InitializeComponent();

            this.organId = organId;

            if (name == "")
                this.organName = "Unknown";
            else
                this.organName = name;

            this.organSlices = organSlices;

            sliceImages.Controls.Add(leftArrow);
            sliceImages.Controls.Add(rightArrow);
            int leftArrowYPosition = (sliceImages.Height - leftArrow.Height) / 2;
            int rightArrowXPosition = sliceImages.Width - rightArrow.Width;
            leftArrow.Location = new Point(0, leftArrowYPosition);
            rightArrow.Location = new Point(rightArrowXPosition, leftArrowYPosition);
            placeholderLabel.Location = new Point(sliceImages.Width / 2 - placeholderLabel.Width / 2, sliceImages.Height / 2 - placeholderLabel.Height / 2);

            contextMenu.Renderer = new MenuRenderer();

            setOrganPanel();
        }

        private async void setOrganPanel()
        {
            organNameLabel.Text = organName;

            int organNameLabelYPos = organNameLabel.Location.Y;
            organNameLabel.Location = new Point(this.Width / 2 - organNameLabel.Width / 2, organNameLabelYPos);
            downArrow.Location = new Point(organNameLabel.Location.X + organNameLabel.Width - 2, organNameLabelYPos);

            await retrieve3dOrgan();

            try
            {
                if (organModel != null)
                {
                    setOrganModel();

                    modelPanel.Visible = true;
                    sliceImages.Visible = false;
                }
                else
                {
                    modelPanel.Visible = false;
                    sliceImages.Visible = true;
                }

                if (organSlices.Count > 0)
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading image: {ex.Message}");
            }
        }

        private void setOrganModel()
        {
            // The file path of the Unity app for displaying the organ
            string relativePath = "3d_viewer\\HoloRepositoryPortable2021.exe";
            string fullPath = Path.Combine(Application.StartupPath, relativePath);

            if (!File.Exists(fullPath))
            {
                // Should add some error handling here
                return;
            }

            IntPtr panelHWND = modelPanel.Handle;

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                FileName = fullPath,
                Arguments = $"-parentHWND {panelHWND.ToInt64()} delayed #{organModel}",
                WindowStyle = ProcessWindowStyle.Hidden,
            };
            Process.Start(startInfo);
        }

        private async Task retrieve3dOrgan()
        {
            var dataSource = DataRetrieval.CreateDataSource();

            string queryModel = $"SELECT model_id, model_path FROM model3d WHERE organ_id = {this.organId}";

            await using (var modelReader = await DataRetrieval.ExecuteQuery(queryModel, dataSource))
            {
                while (await modelReader.ReadAsync())
                {
                    if (modelReader.IsDBNull(1))
                        return;

                    string relativePath = modelReader.GetFieldValue<string>(1);
                    string fullPath = Path.Combine(Application.StartupPath, relativePath);
                    this.organModel = fullPath;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0, 0, this.Width, this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8F, this.Height - 0.8F);

            using (GraphicsPath pathSurface = GetRoundedRectanglePath(rectSurface, BorderRadius))
            using (GraphicsPath pathBorder = GetRoundedRectanglePath(rectBorder, BorderRadius - 1F))
            using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
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

        private void leftArrow_MouseEnter(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                leftArrow.BackColor = Color.LightGray;
            }
        }

        private void leftArrow_MouseLeave(object sender, EventArgs e)
        {
            leftArrow.BackColor = Color.Transparent;
        }

        private void rightArrow_MouseEnter(object sender, EventArgs e)
        {
            if (organSlices.Count > 1)
            {
                rightArrow.BackColor = Color.LightGray;
            }
        }

        private void rightArrow_MouseLeave(object sender, EventArgs e)
        {
            rightArrow.BackColor = Color.Transparent;
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

        private void downArrow_MouseDown(object sender, MouseEventArgs e)
        {
            contextMenu.Show(downArrow, e.Location);
        }

        // The button for updating the organ
        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Parent.Parent.Parent.Parent.Parent.Parent is AddCaseFramework caseFramework)
            {
                try
                {
                    string query = "SELECT donor_Id FROM organ WHERE organ_Id = @organId";
                    var parameters = new Dictionary<string, object>
                    {
                        { "@organId", organId }
                    };
                    using (var reader = dbConnection.ExecuteReader(query, parameters))
                    {
                        if (reader.Read())
                        {
                            int donorId = reader.GetInt32(0);

                            // Use the donorId as needed, for example:
                            //caseFramework.nextBtn.Text = "Update";

                            // Pass the donorId to the AddCaseControl if needed
                            var addCaseControl = new AddCaseControl(donorId, organId); // Assuming AddCaseControl can accept donorId
                            caseFramework.LoadControl(addCaseControl);
                        }
                        else
                        {
                            MessageBox.Show("No donor found for the given organ ID.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred while retrieving donor ID: {ex.Message}");
                }
            }
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

                    string deleteQuery = $"DELETE FROM organ WHERE organ_id = {organId}";
                    dbConnection.ExecuteNonQuery(deleteQuery);
                }
            }
        }

        public void DisposeSliceImages()
        {
            if (sliceImages.Image != null)
            {
                sliceImages.Image.Dispose();
                sliceImages.Image = null;
            }
        }

        private void organNameLabel_MouseEnter(object sender, EventArgs e)
        {
            //MessageBox.Show(Parent.Parent.ToString());
            organNameLabel.ForeColor = Color.FromArgb(51, 129, 202);
        }

        private void organNameLabel_MouseLeave(object sender, EventArgs e)
        {
            organNameLabel.ForeColor = Color.Black;
        }

        private void organNameLabel_Click(object sender, EventArgs e)
        {
            var caseFramework = findAddCaseFramework();

            Control parent = Parent;

            while (parent is not CasePage)
            {
                parent = parent.Parent;
            }

            if (parent is CasePage casePage)
            {
                string pageName = casePage.pageName;
                int donorId = casePage.donorId;

                if (pageName == "caseOverview")
                {
                    if (this.FindForm() is MainForm mainForm)
                    {
                        mainForm.AddControl(new MainInterFaceControl(this, donorId, organId));
                    }
                }
                else
                {
                    var addCaseControl = new AddCaseControl(donorId, organId);

                    if (caseFramework is AddCaseFramework framework)
                        framework.LoadControl(addCaseControl);
                }
            }
        }

        private Control findAddCaseFramework()
        {
            Control parent = Parent;

            while (parent is not AddCaseFramework)
            {
                parent = parent.Parent;
            }

            return parent;
        }
    }
}
