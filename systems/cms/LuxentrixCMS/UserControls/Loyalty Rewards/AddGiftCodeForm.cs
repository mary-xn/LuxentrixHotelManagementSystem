using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.Loyalty_Rewards
{
    public partial class AddGiftCodeForm : Form
    {
        public string GiftCode { get; private set; }
        public string RoomType { get; private set; }
        public string Duration { get; private set; }
        public int Stocks { get; private set; }
        private Form overlay;
        public AddGiftCodeForm(Form overlayForm)
        {
            InitializeComponent();
            this.CenterToParent();
            overlay=overlayForm;
        }

        private void AddGiftCodeForm_Load(object sender, EventArgs e)
        {
            roomTypeComboBox.Items.AddRange(new object[]
            {
                "Standard",
                "Deluxe",
                "Premium",
                "Executive"
            });
            roomTypeComboBox.SelectedIndex = 0;


        }


        private void codeTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void durationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void stockTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void saveThemeBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codeTxtBox.Text))
            {
                MessageBox.Show("Please enter gift code.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }



            GiftCode = codeTxtBox.Text.Trim();
            RoomType = roomTypeComboBox.Text;
            //  Duration = durationComboBox.Text;
            //Stocks = stocks;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
