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
    public partial class AddLoyaltyRewardsForm : Form
    {

        public int PointsRequired { get; private set; }
        public string Discount { get; private set; }
        public string Description { get; private set; }
        public AddLoyaltyRewardsForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void AddLoyaltyRewardsForm_Load(object sender, EventArgs e)
        {

        }

        private void pointsRequiredTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(pointsRequiredTxtBox.Text, out _))
                pointsRequiredTxtBox.Text = string.Concat(pointsRequiredTxtBox.Text.Where(char.IsDigit));
        }


        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            discountTextBox.Text = discountTextBox.Text.Replace("%%", "%");
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(pointsRequiredTxtBox.Text, out int points) || points <= 0)
            {
                MessageBox.Show(
                    "Please enter a valid points value.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(discountTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter discount percentage.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(descriptionTextBox.Text))
            {
                MessageBox.Show(
                    "Please enter description.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            PointsRequired = points;
            Discount = discountTextBox.Text.Trim();
            Description = descriptionTextBox.Text.Trim();

            DialogResult = DialogResult.OK;
            Close();
        }


        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
