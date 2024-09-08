using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HoloRepository
{
    public class IconButton : Button
    {
        private Image buttonImage;
        private string imageFileName;

        [Category("Appearance")]
        [Description("The name of the image file displayed on the button.")]
        public string ImageFileName
        {
            get => imageFileName;
            set
            {
                if (imageFileName != value)
                {
                    imageFileName = value;
                    LoadButtonImage();
                    Invalidate(); // Redraw the button to show the new image
                }
            }
        }

        public IconButton()
        {
            if (!DesignMode)
            {
                LoadButtonImage();
            }
        }

        private void LoadButtonImage()
        {
            try
            {
                if (!string.IsNullOrEmpty(imageFileName))
                {
                    // Get the base directory of the application source
                    string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
                    // Construct the full path to the image file
                    string absoluteImagePath = Path.Combine(projectDirectory, imageFileName);

                    if (File.Exists(absoluteImagePath))
                    {
                        buttonImage = Image.FromFile(absoluteImagePath);
                    }
                    else
                    {
                        throw new FileNotFoundException($"Image file not found, path is {absoluteImagePath}");
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error loading image: {ex.Message}");
                buttonImage = null; // or provide a default image
            }
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            if (buttonImage != null)
            {
                // Get the size of the button
                int buttonWidth = Width;
                int buttonHeight = Height;

                // Get the size of the image
                int imageWidth = buttonImage.Width;
                int imageHeight = buttonImage.Height;

                // Calculate the scaling factor to fit the image within the button
                float scaleFactor = Math.Min((float)buttonWidth / imageWidth, (float)buttonHeight / imageHeight);

                // Calculate the new size of the image
                int newWidth = (int)(imageWidth * scaleFactor);
                int newHeight = (int)(imageHeight * scaleFactor);

                // Calculate the position to center the image in the button
                int x = (buttonWidth - newWidth) / 2;
                int y = (buttonHeight - newHeight) / 2;

                // Draw the scaled image
                pevent.Graphics.DrawImage(buttonImage, x, y, newWidth, newHeight);
            }
            else if (DesignMode)
            {
                // Draw a placeholder image or text in design mode
                using (Font font = new Font("Arial", 8))
                {
                    string text = "BinButton";
                    SizeF textSize = pevent.Graphics.MeasureString(text, font);
                    int x = (Width - (int)textSize.Width) / 2;
                    int y = (Height - (int)textSize.Height) / 2;
                    pevent.Graphics.DrawString(text, font, Brushes.Gray, x, y);
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (DesignMode)
            {
                LoadButtonImage();
                Invalidate(); // Force repaint to show the image in design mode
            }
        }
    }
}
