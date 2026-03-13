using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.Users_Forms
{


    public partial class addUserForm : Form
    {
        public string UserID { get; private set; }
        public string FullName { get; private set; }
        public string Username { get; private set; }
        public string Email { get; private set; }
        public string Role { get; private set; }
        public string Status { get; private set; }
        public string Password { get; private set; }

        private bool isPasswordVisible = false;
        public bool IsEditMode { get; private set; } = false;
        public string OriginalUserID { get; private set; }
        public addUserForm()
        {
            InitializeComponent();
            activeToggleSwitch.Checked = true;
            LoadRoles();
            this.CenterToParent();
        }

        public void LoadUserData(
            string userId,
            string fullName,
            string username,
            string email,
            string role,
            string status
            )
        {
            IsEditMode = true;
            OriginalUserID = userId;
            formLabel.Text = "Edit User Form";
            addButton.Text = "Save Changes";
            addButton.Image = Properties.Resources.icons8_save_50;
            addButton.Font = new Font(addButton.Font.FontFamily,12, FontStyle.Regular);
            addButton.Width = 120;

            userIDTextBox.Text = userId;
            fullNameTxtBox.Text = fullName;
            userNameTextBox.Text = username;
            emailTextBox.Text = email;
            roleComboBox.Text = role;

            activeToggleSwitch.Checked = status == "Active";

            userIDTextBox.Enabled = false;
            passwordTextBox.Enabled = false;
           
        }


        private void LoadRoles()
        {
            roleComboBox.Items.Clear();

            roleComboBox.Items.Add("SuperAdmin");
            roleComboBox.Items.Add("Admin");
            roleComboBox.Items.Add("Manager");
            roleComboBox.Items.Add("Staff");

            roleComboBox.SelectedIndex = 3;
        }

        public void GenerateUserID(string lastUserId)
        {
            int number = int.Parse(lastUserId.Substring(1));
            UserID = $"U{(number + 1):D3}";
            userIDTextBox.Text = UserID;
        }

        private string GeneratePassword(string fullName)
        {
            var parts = fullName.Trim().Split(' ');
            if (parts.Length < 2) return "";

            string firstName = parts[0].ToLower();
            string surnameInitial = parts[^1][0].ToString().ToLower();

            return $"{firstName}.{surnameInitial}";
        }


        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void passwordTxtBox_IconRightClick(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            passwordTextBox.UseSystemPasswordChar = !isPasswordVisible;
            passwordTextBox.IconRight = isPasswordVisible
                ? Properties.Resources.icons8_show_password_24
                : Properties.Resources.icons8_hide_password_24;
        }

        private void userIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullNameTxtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void activeLabel_Click(object sender, EventArgs e)
        {

        }

        private void activeToggleSwitch_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void roleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(fullNameTxtBox.Text) ||
                string.IsNullOrWhiteSpace(userNameTextBox.Text) ||
                roleComboBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please complete all required fields.");
                return;
            }

            FullName = fullNameTxtBox.Text.Trim();
            Username = userNameTextBox.Text.Trim();
            Email = emailTextBox.Text.Trim();
            Role = roleComboBox.Text;
            Status = activeToggleSwitch.Checked ? "Active" : "Deactivated";

            if (!IsEditMode)
            {
                Password = GeneratePassword(FullName);
                passwordTextBox.Text = Password;
            }



            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
