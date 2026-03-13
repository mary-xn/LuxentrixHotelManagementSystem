using LuxentrixContentManagementSystem.Core;
using LuxentrixContentManagementSystem.UserControls.Log_In_Forms;
using LuxentrixContentManagementSystem.UserControls.Users_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace LuxentrixContentManagementSystem.UserControls
{
    public partial class LogInForm : Form
    {
        private bool isPasswordVisible = false;
        private LoadingControl loading;
        private Control[] originalLoginControls;
        public LogInForm()
        {
            InitializeComponent();
            passwordTextBox.IconRightClick += passwordTextBox_IconRightClick;
        }

        private void LogInForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            CenterLoginPanel();
            CenterLoading();

            overlayPanel.Visible = false;
            overlayPanel.BringToFront();

            passwordTextBox.PasswordChar = '●';
            passwordTextBox.UseSystemPasswordChar = false;
            passwordTextBox.IconRightCursor = Cursors.Hand;
        }

        private void LogInForm_Resize(object sender, EventArgs e)
        {
            CenterLoginPanel();
            CenterLoading();
        }

        private void userNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShowLoading()
        {
            overlayPanel.Visible = true;
            overlayPanel.BringToFront();

            loadingLabel.Text = "Signing you in…";
            loader.Value = 0;

            Application.DoEvents(); 
        }

        private async Task AnimateLoading()
        {
            for (int i = 0; i <= 400; i += 4)
            {
                loader.Value = i;
                await Task.Delay(30);
            }

        }
        private void CenterLoginPanel()
        {
            logInPanel.Left = (ClientSize.Width - logInPanel.Width) / 2;
            logInPanel.Top  = (ClientSize.Height - logInPanel.Height) / 2;
        }

        private void CenterLoading()
        {
            loadingContainer.Left =
                (overlayPanel.Width - loadingContainer.Width) / 2;

            loadingContainer.Top =
                (overlayPanel.Height - loadingContainer.Height) / 2;
        }




        private void passwordTextBox_IconRightClick(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;

            if (isPasswordVisible)
            {
                passwordTextBox.PasswordChar = '\0';
                passwordTextBox.IconRight = Properties.Resources.icons8_show_password_24;
            }
            else
            {
                passwordTextBox.PasswordChar = '●';
                passwordTextBox.IconRight = Properties.Resources.icons8_hide_password_24;
            }
        }


        private string HashPassword(string password)
        {
            using (var sha = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                return Convert.ToBase64String(sha.ComputeHash(bytes));
            }
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mainPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void logInPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void overlayPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void logInBtn_Click(object sender, EventArgs e)
        {
            string username = userNameTextBox.Text.Trim();
            string password = passwordTextBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            string hashedPassword = HashPassword(password);

            var user = Core.UserStore.Users.AsEnumerable()
                .FirstOrDefault(r =>
                    r["Username"].ToString().Equals(username, StringComparison.OrdinalIgnoreCase) &&
                    r["PasswordHash"].ToString() == hashedPassword
                );

            if (user == null)
            {
                Core.Logger.Log(
                    action: "LOGIN_FAILED",
                    module: "Authentication",
                    description: $"Failed login attempt for username: {username}"
                );

                MessageBox.Show("Invalid username or password.");
                return;
            }
            if (user["Status"].ToString() != "Active")
            {
                Core.Logger.Log(
                       action: "LOGIN_BLOCKED",
                       module: "Authentication",
                       description: $"Deactivated account attempted login: {username}"
                   );

                MessageBox.Show("This account is deactivated.");
                return;
            }

            Core.UserSession.UserID   = user["UserID"].ToString();
            Core.UserSession.Username = user["Username"].ToString();
            Core.UserSession.FullName = user["FullName"].ToString();
            Core.UserSession.Role     = user["Role"].ToString();


            Core.Logger.Log(
                action: "LOGIN",
                module: "Authentication",
                description: $"User {Core.UserSession.Username} logged in successfully"
            );

           
            ShowLoading();

            await AnimateLoading();

            MainDashboard dashboard = new MainDashboard();
            dashboard.Opacity = 0;   
            dashboard.Show();

            await Task.Delay(150);   

            dashboard.Opacity = 1;
            this.Hide();

        }
    }
}
