using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.Forms.Food_Menu_Forms
{
    public partial class addAmenityForm : Form
    {
        public addAmenityForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterParent;
        }

        private void formPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            overlayForm overlay = new overlayForm();
            overlay.Close();
            this.Close();
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void categeroyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void itemNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void priceTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void descriptionTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
