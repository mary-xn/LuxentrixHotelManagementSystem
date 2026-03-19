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
    public partial class changeNameForm : Form
    {
        private Form overlay;
        public changeNameForm(Form overlayForm)
        {
            InitializeComponent();
            this.CenterToParent();
            overlay = overlayForm;
        }

        private void passwordTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeNameBtn_Click(object sender, EventArgs e)
        {

        }

        private void newNameTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click_1(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void changeNameBtn_Click_1(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void newNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
