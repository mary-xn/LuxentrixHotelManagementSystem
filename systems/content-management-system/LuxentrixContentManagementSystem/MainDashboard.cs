using Guna.UI2.WinForms;
using LuxentrixContentManagementSystem.Core;
using LuxentrixContentManagementSystem.Forms;
using LuxentrixContentManagementSystem.Forms.Food_Menu_Forms;
using LuxentrixContentManagementSystem.Forms.Room_Forms;
using LuxentrixContentManagementSystem.Forms.Room_Services_Forms;
using LuxentrixContentManagementSystem.UserControls;
using LuxentrixContentManagementSystem.UserControls.Activity_Logs;
using LuxentrixContentManagementSystem.UserControls.Loyalty_Rewards;
using LuxentrixContentManagementSystem.UserControls.Users_Forms;
using LuxentrixContentManagementSystem.UserControls.MainDashBoard;

namespace LuxentrixContentManagementSystem
{
    public partial class MainDashboard : Form
    {
        private Form? currentForm;
        private Form? nextForm;
        private bool isFadingOut;
        private System.Windows.Forms.Timer transitionTimer;
        private Control? currentView;
        private DashboardView _dashboardView;

        public MainDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.Controls.SetChildIndex(mainPanelPanel, 0);
            ResetSidebarButtons();
            FlickerFix.Enable(this);
            FlickerFix.Enable(contentPanel);

            _dashboardView = new DashboardView
            {
                Dock = DockStyle.Fill
            };

            contentPanel.Controls.Add(_dashboardView);
            _dashboardView.Visible = true;
            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Guna.UI2.WinForms.Guna2Button btn)
                {
                    btn.Cursor = Cursors.Hand;
                }
            }
            userSystemSettingPanel.Parent = this;
            userSystemSettingPanel.BringToFront();
            userSystemSettingPanel.Visible = false;
            currentUserName.Text = Core.UserSession.FullName;
            currentRole.Text = Core.UserSession.Role.ToString();
            nameLabel.Text = Core.UserSession.FullName;
            SetUserSystemButton();
            userPictureBox.FillColor = Color.FromArgb(208, 189, 172);

            typeof(Control)
            .GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
            ?.SetValue(contentPanel, true);
        }

        private void SetUserSystemButton()
        {
            if (userSystemButton.Image != null)
                return;

            userSystemButton.Text =
                string.IsNullOrWhiteSpace(Core.UserSession.FullName)
                    ? "?"
                    : Core.UserSession.FullName
                        .Trim()
                        .Split(' ', StringSplitOptions.RemoveEmptyEntries)[0][0]
                        .ToString()
                        .ToUpper();
            userPictureBox.Text = userSystemButton.Text;
        }

        private void LoadFormInPanel(Form childForm)
        {
            contentPanel.SuspendLayout();

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Bounds = contentPanel.ClientRectangle;
            childForm.Dock = DockStyle.None;
            childForm.Opacity = 0;

            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(childForm);

            childForm.Show();
            contentPanel.ResumeLayout();

            StartFadeIn(childForm);
        }

        private void StartFadeIn(Form form)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 15;

            t.Tick += (s, e) =>
            {
                form.Opacity += 0.05;

                if (form.Opacity >= 1)
                {
                    form.Opacity = 1;
                    t.Stop();
                    t.Dispose();
                }
            };

            t.Start();
        }

        private void TransitionTimer_Tick(object? sender, EventArgs e)
        {
            if (isFadingOut)
            {
                if (currentForm != null)
                {
                    currentForm.Opacity -= 0.08;

                    if (currentForm.Opacity <= 0)
                    {
                        contentPanel.Controls.Remove(currentForm);
                        currentForm.Dispose();
                        currentForm = null;
                    }
                }

                isFadingOut = false;

                contentPanel.Controls.Clear();
                contentPanel.Controls.Add(nextForm!);
                currentForm = nextForm;
                nextForm = null;

                currentForm.Show();
            }
            else
            {
                if (currentForm != null)
                {
                    currentForm.Opacity += 0.05;

                    if (currentForm.Opacity >= 1)
                    {
                        currentForm.Opacity = 1;
                        transitionTimer.Stop();
                    }
                }
            }
        }

        private void ResetSidebarButtons()
        {
            foreach (Control ctrl in sidePanel.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.FillColor = Color.Transparent;
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void roomsBtn_Click(object sender, EventArgs e)
        {
            LoadFormInPanel(new RoomForm());
        }

        private void roomsBtn_Click_1(object sender, EventArgs e)
        {
            ResetSidebarButtons();
            SwitchView(new RoomView());
            roomsBtn.FillColor = Color.FromArgb(133, 102, 84);
            roomsBtn.ForeColor = Color.White;
            commonLabel.Text = "Rooms Management";
        }


        private void amenitiesBtn_Click(object sender, EventArgs e)
        {
            ResetSidebarButtons();
            LoadFormInPanel(new Amenities());
            amenitiesBtn.FillColor = Color.FromArgb(133, 102, 84);
            amenitiesBtn.ForeColor = Color.White;
            commonLabel.Text = "Amenities Management";
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ResetSidebarButtons();

            SwitchView(_dashboardView);

            dashboardBtn.FillColor = Color.FromArgb(133, 102, 84);
            dashboardBtn.ForeColor = Color.White;
            commonLabel.Text = "Dashboard";

        }


        private void SwitchView(UserControl view)
        {
            contentPanel.SuspendLayout();
            contentPanel.Visible = false;

            if (!contentPanel.Controls.Contains(view))
            {
                contentPanel.Controls.Clear();
                view.Dock = DockStyle.Fill;
                contentPanel.Controls.Add(view);
            }

            contentPanel.Visible = true;
            contentPanel.ResumeLayout(true);
        }

        private void guna2Button6_Click(object sender, EventArgs e) { }
        private void contentPanel_Paint(object sender, PaintEventArgs e) { }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e) { }
        private void headerPanel_Paint(object sender, PaintEventArgs e) { }
        private void contentPanel_Paint_1(object sender, PaintEventArgs e) { }
        private void headerPanel_Paint_1(object sender, PaintEventArgs e) { }
        private void mainPanelPanel_Paint(object sender, PaintEventArgs e) { }
        private void contentPanel_Paint_2(object sender, PaintEventArgs e) { }
        private void sidePanel_Paint(object sender, PaintEventArgs e) { }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ResetSidebarButtons();
            SwitchView(new ServicesView());
            amenitiesBtn.FillColor = Color.FromArgb(133, 102, 84);
            amenitiesBtn.ForeColor = Color.White;
            commonLabel.Text = "Services Management";
        }

        private void logoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void commonPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void userSystemButton_Click(object sender, EventArgs e)
        {
            if (userSystemSettingPanel.Visible)
            {
                userSystemSettingPanel.Visible = false;
                return;
            }

            userSystemSettingPanel.SuspendLayout();

            PositionUserPanel();

            userSystemSettingPanel.BackColor = Color.FromArgb(160, 0, 0, 0);
            userSystemSettingPanel.BringToFront();
            userSystemSettingPanel.Visible = true;

            userSystemSettingPanel.ResumeLayout();


        }

        private void PositionUserPanel()
        {
            Point buttonScreenLocation = userSystemButton.PointToScreen(Point.Empty);
            Point formLocation = this.PointToClient(buttonScreenLocation);

            userSystemSettingPanel.Location = new Point(
                formLocation.X + userSystemButton.Width - userSystemSettingPanel.Width,
                formLocation.Y + userSystemButton.Height + 5
            );
        }


        private void userSystemSettingPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void userSystemChangeablePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutFinalBtn_Click(object sender, EventArgs e)
        {
            Logout();
        }

        private void Logout()
        {
            DialogResult result = logOutConfirmationDialogue.Show();

            if (result == DialogResult.Yes)
            {
                Core.Logger.Log(
                action: "LOGOUT",
                module: "Authentication",
                description: $"User {Core.UserSession.Username} logged out"
                 );

                Core.UserSession.Clear();

                new LogInForm().Show();
                this.Close();
            }
        }

        private void userSystemChangeBtn_Click(object sender, EventArgs e)
        {
            accSettingLayOutPanel.Visible = true;
        }

        private void loyaltyRewardsBtn_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin, Roles.Manager))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            ResetSidebarButtons();
            SwitchView(new LoyaltyRewards());
            loyaltyRewardsBtn.FillColor = Color.FromArgb(133, 102, 84);
            loyaltyRewardsBtn.ForeColor = Color.White;
            commonLabel.Text = "Guest Loyalty Rewards";
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            ResetSidebarButtons();
            SwitchView(new usersManagement());
            usersBtn.FillColor = Color.FromArgb(133, 102, 84);
            usersBtn.ForeColor = Color.White;
            commonLabel.Text = "Users Management";
        }

        private void activityLogsButton_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            ResetSidebarButtons();
            SwitchView(new ActivityLog());
            activityLogsButton.FillColor = Color.FromArgb(133, 102, 84);
            activityLogsButton.ForeColor = Color.White;
            commonLabel.Text = "Activity Logs";
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void backButton_Click(object sender, EventArgs e)
        {
            accSettingLayOutPanel.Visible = false;
            nameLabel.ForeColor = Color.Black;
        }

        //For change password and change name, I want to make the main panel a bit darker
        //and show the change password or change name form in the middle of the screen as a dialog
        private void changePasswordBtn_Click(object sender, EventArgs e)
        {
            mainPanelPanel.BackColor = Color.FromArgb(120, 0, 0, 0);

            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.StartPosition = FormStartPosition.CenterParent;
            changePasswordForm.ShowDialog();

            mainPanelPanel.BackColor = Color.Transparent;
        }

        private void ChangeNameBtn_Click(object sender, EventArgs e)
        {
            var changeNameForm = new changeNameForm();
            changeNameForm.ShowDialog();
        }

        private void userPictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void currentUserName_Click(object sender, EventArgs e)
        {

        }

        private void currentRole_Click(object sender, EventArgs e)
        {

        }
    }
}
