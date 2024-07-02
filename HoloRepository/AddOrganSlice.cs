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
    public partial class AddOrganSlice : Form
    {
        private List<Image> imageList = new List<Image>();
        private SliderControl sliderControl;

        public AddOrganSlice()
        {
            InitializeComponent();
            imageList = new List<Image>();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Multiselect = true; // 允许多选

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // 清空当前的图像列表
                    imageList.Clear();

                    // 遍历选择的文件路径，并加载图像
                    foreach (string filePath in openFileDialog.FileNames)
                    {
                        Image selectedImage;
                        try
                        {
                            selectedImage = new Bitmap(filePath);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error loading image: {ex.Message}");
                            continue; // 跳过错误的图像
                        }
                        imageList.Add(selectedImage);
                    }

                    // 设置 SliderControl 的分割数量
                    sliderControl1.NumberOfImages = imageList.Count;

                    // 更新 SliderControl 在 OrganSlicePanel 中的布局
                    UpdateSliderControlLayout();

                    // 显示第一个图像，如果有图像被选中
                    if (imageList.Count > 0)
                    {
                        ShowImage(imageList[0]);
                    }
                }
            }
        }

        private void UpdateSliderControlLayout()
        {
            int sliderWidth = 234; // sliderControl1 的宽度
            int panelWidth = OrganSlicePanel.Width;
            int sliderX = (panelWidth - sliderWidth) / 2; // 计算 SliderControl 在 Panel 中的 X 坐标

            sliderControl1.Location = new Point(sliderX, 3);
        }

        private void SliderControl1_ImageSelected(object sender, int index)
        {
            if (index >= 0 && index < imageList.Count)
            {
                DICOMFilePicture.Image = imageList[index];
            }
        }


        private void ShowImage(Image image)
        {
            if (image != null)
            {
                DICOMFilePicture.Image = image;
            }
            else
            {
                MessageBox.Show("Image is null.");
            }
        }
    }
}
