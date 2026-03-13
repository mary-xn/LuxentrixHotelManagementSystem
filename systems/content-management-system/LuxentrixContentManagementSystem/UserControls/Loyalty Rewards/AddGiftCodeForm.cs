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
        public AddGiftCodeForm()
        {
            InitializeComponent();
            this.CenterToParent();
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

            durationComboBox.Items.AddRange(new object[]
            {
                "3",
                "6",
                "12",
                "24"
            });
            durationComboBox.SelectedIndex = 0;
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

            if (!int.TryParse(stockTextBox.Text, out int stocks) || stocks <= 0)
            {
                MessageBox.Show("Please enter a valid stock number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GiftCode = codeTxtBox.Text.Trim();
            RoomType = roomTypeComboBox.Text;
            Duration = durationComboBox.Text;
            Stocks = stocks;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
