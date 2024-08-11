using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace HoloRepository
{
    public partial class MainInterfaceSlicePanel : UserControl
    {
        private List<PictureBox> pictureBoxList;
        private DatabaseConnection dbConnection;
        private Image plusImage;

        private int donorId;
        private int organId;

        private int startIndex = 0; // The starting index for displaying 3D panels
        private List<Image> sliceImages = new List<Image>(); // List of preloaded images
        private const int maxPictureBoxes = 3;

        public event Action<Image> PictureBoxClicked;

        public MainInterfaceSlicePanel(int donorId, int organId)
        {
            InitializeComponent();
            this.donorId = donorId;
            this.organId = organId;
            dbConnection = new DatabaseConnection();

            plusImage = CreatePlusImage();

            pictureBoxList = new List<PictureBox> { pictureBox1, pictureBox2, pictureBox3 };
            LoadSlices(donorId, organId); // Preload images into memory
            UpdatePictureBoxes();         // Display the first set of images
            CheckVisibility();

            // 为每个 PictureBox 添加点击事件处理程序
            foreach (var pictureBox in pictureBoxList)
            {
                pictureBox.Click += PictureBox_Click;
            }
        }

        private void LoadSlices(int donorId, int organId)
        {
            string query = @"
                SELECT image_path 
                FROM sliceimage 
                WHERE organ_id = @organId
                ORDER BY slice_id"; // Assuming there is a slice_id to order the slices

            var parameters = new Dictionary<string, object>
            {
                { "@organId", organId }
            };

            try
            {
                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(query, connection))
                {
                    foreach (var param in parameters)
                    {
                        command.Parameters.AddWithValue(param.Key, param.Value);
                    }

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string imagePath = reader.GetString(0);

                            // Preload the image into memory
                            if (System.IO.File.Exists(imagePath))
                            {
                                Image image = Image.FromFile(imagePath);
                                sliceImages.Add(image);
                            }
                            else
                            {
                                MessageBox.Show($"Image not found: {imagePath}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading slices: " + ex.Message);
            }
        }

        private void UpdatePictureBoxes()
        {
            // 当 startIndex 为 0 时，第一个 PictureBox 显示加号图片
            if (startIndex == 0)
            {
                pictureBoxList[0].Image = plusImage; // 使用保存的加号图片
                pictureBoxList[0].Tag = null; // 加号图片不绑定数据

                // 从第二个 PictureBox 开始显示切片图像
                for (int i = 1; i < maxPictureBoxes; i++)
                {
                    if (i - 1 + startIndex < sliceImages.Count)
                    {
                        pictureBoxList[i].Image = sliceImages[i - 1 + startIndex];
                        pictureBoxList[i].Tag = sliceImages[i - 1 + startIndex];
                    }
                    else
                    {
                        pictureBoxList[i].Image = null; // 如果没有图片，则清空
                        pictureBoxList[i].Tag = null;
                    }
                }
            }
            else
            {
                // 当 startIndex 不为 0 时，所有 PictureBox 显示实际切片图像
                for (int i = 0; i < maxPictureBoxes; i++)
                {
                    if (i + startIndex - 1 < sliceImages.Count) // 调整索引
                    {
                        pictureBoxList[i].Image = sliceImages[i + startIndex - 1];
                        pictureBoxList[i].Tag = sliceImages[i + startIndex - 1];
                    }
                    else
                    {
                        pictureBoxList[i].Image = null; // 如果没有图片，则清空
                        pictureBoxList[i].Tag = null;
                    }
                }
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            PictureBox clickedPictureBox = sender as PictureBox;

            if (clickedPictureBox == pictureBoxList[0] && clickedPictureBox.Image != null && clickedPictureBox.Image == plusImage)
            {
                ShowAddOrganSliceDialog();
            }
            else if (clickedPictureBox != null && clickedPictureBox.Tag is Image image)
            {
                PictureBoxClicked?.Invoke(image); // 触发事件并传递图片
            }
        }



        private void CheckVisibility()
        {
            this.Visible = sliceImages.Count > 0;
        }

        private void rightArrow_Click(object sender, EventArgs e)
        {
            if (startIndex < sliceImages.Count - (maxPictureBoxes - 1))
            {
                startIndex++;
                UpdatePictureBoxes();
            }
        }

        private void leftArrow_Click(object sender, EventArgs e)
        {
            if (startIndex > 0)
            {
                startIndex--;
                UpdatePictureBoxes();
            }
        }

        private Image CreatePlusImage()
        {
            int width = 100;
            int height = 100;
            Bitmap bmp = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                Pen pen = new Pen(Color.Gray, 5);

                int centerX = width / 2;
                int centerY = height / 2;
                int lineLength = 30;

                g.DrawLine(pen, centerX - lineLength / 2, centerY, centerX + lineLength / 2, centerY);

                g.DrawLine(pen, centerX, centerY - lineLength / 2, centerX, centerY + lineLength / 2);
            }

            return bmp;
        }

        private void ShowAddOrganSliceDialog()
        {
            string organName = string.Empty;
            string organSide = string.Empty;
            int sliceIndex = sliceImages.Count + 1; // sliceIndex 为现有 sliceImage 的个数加 1

            // 查询 organ_name 和 organ_side
            try
            {
                string organQuery = @"
                    SELECT o.organ_name_id, o.organ_side, n.organ_name
                    FROM organ o
                    JOIN organname n ON o.organ_name_id = n.organ_name_id
                    WHERE o.organ_id = @organId";

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(organQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            organName = reader.GetString(reader.GetOrdinal("organ_name"));

                            // 检查 organ_side 是否为 null
                            if (!reader.IsDBNull(reader.GetOrdinal("organ_side")))
                            {
                                organSide = reader.GetString(reader.GetOrdinal("organ_side"));
                            }
                            else
                            {
                                organSide = string.Empty;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving organ information: " + ex.Message);
                return;
            }

            List<Image> dicomImages = new List<Image>();
            Dictionary<int, int> dicomIdMap = new Dictionary<int, int>();
            try
            {
                string dicomQuery = @"
                    SELECT dicom_id, dicom_path 
                    FROM dicomfile 
                    WHERE organ_id = @organId
                    ORDER BY dicom_id"; // Assuming there is a dicom_id to order the files

                using (var connection = dbConnection.GetConnection())
                using (var command = new NpgsqlCommand(dicomQuery, connection))
                {
                    command.Parameters.AddWithValue("@organId", organId);

                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int dicomId = reader.GetInt32(0);
                            string dicomPath = reader.GetString(1);

                            // Preload the DICOM image into memory
                            if (System.IO.File.Exists(dicomPath))
                            {
                                Image dicomImage = Image.FromFile(dicomPath);
                                dicomImages.Add(dicomImage);
                                dicomIdMap[dicomImages.Count - 1] = dicomId;  // Map index to dicomPath
                            }
                            else
                            {
                                MessageBox.Show($"DICOM file not found: {dicomPath}");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading DICOM files: " + ex.Message);
                return; // 发生错误时不显示对话框
            }

            // 创建 AddOrganSlice 窗口的实例
            AddOrganSlice addOrganSliceForm = new AddOrganSlice(donorId, organName, sliceIndex, organSide);

            // 传递查询到的 DICOM 文件图像列表
            addOrganSliceForm.SetImageList(dicomImages, 0); // 默认显示第一张图像

            // 订阅 OrganSliceUpdated 事件以便在新切片添加后进行处理
            addOrganSliceForm.OrganSliceUpdated += (organSliceImage, selectedImage, description, index) =>
            {
                string imagePath = addOrganSliceForm.OrganSliceImagePath;

                if (dicomIdMap.TryGetValue(index, out int selectedDicomId))
                {
                    InsertSliceImageToDatabase(organId, selectedDicomId, description, imagePath);
                }
                else
                {
                    MessageBox.Show($"Error: No DICOM ID found for index {index}.", "DICOM ID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sliceImages.Add(organSliceImage);
                UpdatePictureBoxes(); // 更新显示
            };

            // 显示窗口为模态对话框
            addOrganSliceForm.ShowDialog();
        }

        private void InsertSliceImageToDatabase(int organId, int dicomId, string description, string imagePath)
        {
            try
            {
                string query = @"
            INSERT INTO sliceimage (organ_id, dicom_id, additional_info, image_path)
            VALUES (@organId, @dicomId, @additionalInfo, @imagePath)";

                using (var connection = dbConnection.GetConnection())
                {
                    // 在这里检查连接状态，并只在必要时打开连接
                    if (connection.State != System.Data.ConnectionState.Open)
                    {
                        connection.Open();
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@organId", organId);
                        command.Parameters.AddWithValue("@dicomId", dicomId);
                        command.Parameters.AddWithValue("@additionalInfo", description);
                        command.Parameters.AddWithValue("@imagePath", imagePath);

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Slice image inserted into the database successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inserting slice image into the database: {ex.Message}");
            }
        }


    }
}
