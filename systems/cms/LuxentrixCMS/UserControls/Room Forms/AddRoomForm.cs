using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.Forms
{

    public partial class AddRoomForm : Form


    {
        private DataTable _roomTypeTable;
        private Image _selectedImage;

        public AddRoomForm(DataTable roomTypeTable)
        {
            InitializeComponent();
            CenterToParent();
            LoadRoomTypeComboBox();

            _roomTypeTable = roomTypeTable;
        }



        private void LoadRoomTypeComboBox()
        {
            roomTypeComboBox.Items.Clear();
            roomTypeComboBox.Items.Add("All");
            roomTypeComboBox.Items.Add("Standard");
            roomTypeComboBox.Items.Add("Deluxe");
            roomTypeComboBox.Items.Add("Suite");
            roomTypeComboBox.SelectedIndex = 0;
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void themeNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void stockTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void themeImagePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void uploadImageBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.png;*.jpeg";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _selectedImage = Image.FromFile(ofd.FileName);
                    themeImagePictureBox.Image = _selectedImage;
                    themeImagePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void removeImageBtn_Click(object sender, EventArgs e)
        {
            themeImagePictureBox.Image = null;
            _selectedImage = null;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

        }

        private void saveThemeBtn_Click(object sender, EventArgs e)
        {
            // Basic validation
            if (roomTypeComboBox.SelectedIndex <= 0)
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            if (string.IsNullOrWhiteSpace(themeNameTxtBox.Text))
            {
                MessageBox.Show("Theme name is required.");
                return;
            }

            if (!int.TryParse(stockTextBox.Text, out int stock) || stock < 0)
            {
                MessageBox.Show("Invalid stock value.");
                return;
            }

            byte[] imageBytes = null;
            if (_selectedImage != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    _selectedImage.Save(ms, _selectedImage.RawFormat);
                    imageBytes = ms.ToArray();
                }
            }
            _roomTypeTable.Rows.Add(
    roomTypeComboBox.Text,
    themeNameTxtBox.Text.Trim(),
    stock.ToString()
);
            DialogResult = DialogResult.OK;
            Close();
        }
        

        private void addedByUsersNameLabel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
