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
    public partial class AddVoucherForm : Form
    {
        public string VoucherCode { get; private set; }
        public string Discount { get; private set; }
        public int Stocks { get; private set; }
        public AddVoucherForm()
        {
            InitializeComponent();
            this.CenterToParent();
        }

        private void codeTxtBox_TextChanged(object sender, EventArgs e)
        {
            codeTxtBox.Text = codeTxtBox.Text.ToUpper();
            codeTxtBox.SelectionStart = codeTxtBox.Text.Length;
        }

        private void discountTxtBox_TextChanged(object sender, EventArgs e)
        {
            discountTxtBox.Text = discountTxtBox.Text.Replace("%%", "%");
        }

        private void stockTxtBox_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(stockTxtBox.Text, out _))
                stockTxtBox.Text = string.Concat(stockTxtBox.Text.Where(char.IsDigit));
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(codeTxtBox.Text))
            {
                MessageBox.Show(
                    "Please enter voucher code.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (string.IsNullOrWhiteSpace(discountTxtBox.Text))
            {
                MessageBox.Show(
                    "Please enter discount percentage.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            if (!int.TryParse(stockTxtBox.Text, out int stocks) || stocks <= 0)
            {
                MessageBox.Show(
                    "Please enter valid stock value.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            VoucherCode = codeTxtBox.Text.Trim();
            Discount = discountTxtBox.Text.Trim();
            Stocks = stocks;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
