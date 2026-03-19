using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.MainDashBoard
{
    public partial class ChangePasswordForm : Form
    {
        private Form overlay;
        public ChangePasswordForm(Form overlayForm)
        {
            InitializeComponent();
            this.CenterToParent();
            overlay = overlayForm;
        }


        private void newPassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void reTypeNewPassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changePassBtn_Click(object sender, EventArgs e)
        {

        }

        private void currentPassTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        //to be deleted
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exitButton_Click_2(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void currentPassTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void newPassTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void reTypeNewPassTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void changePassBtn_Click_1(object sender, EventArgs e)
        {

        }
    }
}
