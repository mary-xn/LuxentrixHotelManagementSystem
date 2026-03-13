using Guna.UI2.WinForms;
using LuxentrixContentManagementSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.Users_Forms
{
    public partial class usersManagement : UserControl
    {

        private DataTable usersTable = new DataTable();
        private DataView usersView;
        public static DataTable UsersData { get; private set; }

        private bool isDeactivatedView = false;
        public usersManagement()
        {
            InitializeComponent();
            LoadUsersData();
            SetupGrid();
            StyleRoomsGrid();
            allUsersBtn_Click(null, null);
            LoadRoleFilter();
            usersDataGridView.ClearSelection();
            usersDataGridView.SelectionChanged += usersDataGridView_SelectionChanged;
            usersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            usersDataGridView.MultiSelect = false;
        }

        private void LoadUsersData()
        {
            usersTable.Clear();
            usersTable.Columns.Clear();

            usersTable.Columns.Add("UserID");
            usersTable.Columns.Add("FullName");
            usersTable.Columns.Add("Username");
            usersTable.Columns.Add("Email");
            usersTable.Columns.Add("PasswordHash");
            usersTable.Columns.Add("Role");
            usersTable.Columns.Add("Status");
            usersTable.Columns.Add("ForcePasswordChange");

            usersTable.Rows.Add(
                "U000",
                "System Owner",
                "superadmin",
                "admin@luxentrix.com",
                HashPassword("superadmin.s"),
                "SuperAdmin",
                "Active"
            );

            usersTable.Rows.Add(
                "U001",
                "Juan Dela Cruz",
                "juan.dc",
                "juan.dc@luxentrix.com",
                HashPassword("juan.d"),
                "Admin",
                "Active"
            );

            usersTable.Rows.Add(
                "U002",
                "Maria Santos",
                "maria.s",
                "maria.s@luxentrix.com",
                HashPassword("maria.s"),
                "Staff",
                "Active"
            );

            usersTable.Rows.Add(
                "U003",
                "Pedro Reyes",
                "pedro.r",
                "pedro.r@luxentrix.com",
                HashPassword("pedro.r"),
                "Manager",
                "Active"
            );

            usersTable.Rows.Add(
                "U004",
                "Patricia Lopez",
                "patricia.l",
                "patricia.l@luxentrix.com",
                HashPassword("patricia.l"),
                "Staff",
                "Deactivated"
            );

            usersTable.Rows.Add(
                "U005",
                "Carlos Gomez",
                "carlos.g",
                "carlos.g@luxentrix.com",
                HashPassword("carlos.g"),
                "Staff",
                "Deactivated"
            );

            usersTable = Core.UserStore.Users;
            usersView = new DataView(usersTable);
            usersDataGridView.DataSource = usersView;
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }



        private void LoadRoleFilter()
        {
            filterByRoleComboBox.Items.Clear();
            filterByRoleComboBox.Items.Add("All Roles");
            filterByRoleComboBox.Items.Add("SuperAdmin");
            filterByRoleComboBox.Items.Add("Admin");
            filterByRoleComboBox.Items.Add("Manager");
            filterByRoleComboBox.Items.Add("Staff");

            filterByRoleComboBox.SelectedIndex = 0;
        }

        private void ApplyUserFilters()
        {
            List<string> filters = new List<string>();

            if (isDeactivatedView)
                filters.Add("Status = 'Deactivated'");
            else
                filters.Add("Status = 'Active'");

            if (filterByRoleComboBox.SelectedIndex > 0)
            {
                string role = filterByRoleComboBox.Text.Replace("'", "''");
                filters.Add($"Role = '{role}'");
            }

            string searchText = searchTxtBox.Text.Trim().Replace("'", "''");
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filters.Add($@"
                (
                    FullName LIKE '%{searchText}%'
                    OR Username LIKE '%{searchText}%'
                    OR UserID LIKE '%{searchText}%'
                    OR Status LIKE '%{searchText}%'
                    OR Role LIKE '%{searchText}%'
                    OR Email LIKE '%{searchText}%' 
                )");
            }

            usersView.RowFilter = string.Join(" AND ", filters);
        }


        private void ResetButtons()
        {
            foreach (Control ctrl in tagsPanel.Controls)
            {
                if (ctrl is Guna2Button btn)
                {
                    btn.FillColor = Color.FromArgb(208, 189, 172);
                    btn.ForeColor = Color.Black;
                }
            }
        }

        private void SetupGrid()
        {
            usersDataGridView.AutoGenerateColumns = false;
            usersDataGridView.Columns.Clear();

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "UserID",
                HeaderText = "User ID"
            });

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full Name"
            });

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Username",
                HeaderText = "Username"
            });

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Email",
                HeaderText = "Email"
            });

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Role",
                HeaderText = "Role"
            });

            usersDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Status",
                HeaderText = "Status"
            });

            usersDataGridView.ReadOnly = true;
            usersDataGridView.AllowUserToAddRows = false;
            usersDataGridView.RowHeadersVisible = false;
        }

        private void HideActionButtons()
        {
            editBtn.Visible = false;
            deleteUserBtn.Visible = false;
            resetPasswordButton.Visible = false;
        }

        private void StyleRoomsGrid()
        {
            var grid = usersDataGridView;

            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.RowTemplate.Height = 38;

            grid.ThemeStyle.HeaderStyle.Height = 40;
            grid.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);
            grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(133, 102, 84);
            grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;

            grid.ThemeStyle.RowsStyle.SelectionBackColor =
                Color.FromArgb(208, 189, 172);

            grid.RowHeadersVisible = false;
            grid.ReadOnly = true;
            grid.AllowUserToAddRows = false;

            typeof(DataGridView)
                .GetProperty("DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic)!
                .SetValue(grid, true, null);
        }



        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyUserFilters();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();
        }

        private void filterByRoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyUserFilters();
        }

        private void allUsersBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            allUsersBtn.FillColor = Color.FromArgb(133, 102, 84);
            allUsersBtn.ForeColor = Color.White;
            isDeactivatedView = false;
            usersView.RowFilter = "Status = 'Active'";
            HideActionButtons();
        }


        private void deactivatedUsersBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            deactivatedUsersBtn.FillColor = Color.FromArgb(133, 102, 84);
            deactivatedUsersBtn.ForeColor = Color.White;
            isDeactivatedView = true;
            usersView.RowFilter = "Status = 'Deactivated'";
            HideActionButtons();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            string lastUserId = usersTable.Rows.Count > 0
                ? usersTable.Rows[^1]["UserID"].ToString()
                : "U000";

            using (var form = new addUserForm())
            {
                form.GenerateUserID(lastUserId);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    usersTable.Rows.Add(
                        form.UserID,
                        form.FullName,
                        form.Username,
                         HashPassword(form.Password),
                        form.Role,
                        form.Status
                    );

                    usersView = new DataView(usersTable);
                    usersDataGridView.DataSource = usersView;

                    MessageBox.Show(
                        $"User created successfully.\n\nTemporary Password:\n{form.Password}\n\nPlease ask the user to change it.",
                        "User Created",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }

        private string GenerateTemporaryPassword()
        {
            const string chars = "ABCDEFGHJKLMNPQRSTUVWXYZ23456789";
            Random rnd = new Random();

            return new string(Enumerable
                .Repeat(chars, 8)
                .Select(s => s[rnd.Next(s.Length)])
                .ToArray());
        }


        private void usersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                editBtn_Click(sender, e);
        }


        private void usersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            editBtn.Enabled = true;
            deleteUserBtn.Enabled = true;
            resetPasswordButton.Enabled = true;
            if (usersDataGridView.CurrentRow == null)
            {
                HideActionButtons();
                return;
            }

            var row = ((DataRowView)usersDataGridView.CurrentRow.DataBoundItem).Row;

            if (isDeactivatedView)
            {
                editBtn.Visible = true;
                editBtn.Text = "Restore Account";
                editBtn.Width = 130;
                editBtn.Image = Properties.Resources.icons8_restore_50;

                deleteUserBtn.Visible = false;
                resetPasswordButton.Visible = false;
            }
            else
            {
                editBtn.Visible = true;
                deleteUserBtn.Visible = true;
                resetPasswordButton.Visible = true;

                editBtn.Text = "Edit Account";
                editBtn.Image = Properties.Resources.icons8_edit_32;
                deleteUserBtn.Text = "Deactivate User";
            }
        }



        private void tagsPanel_Paint(object sender, PaintEventArgs e)
        {

        }


        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void resetPasswordButton_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            
            if (usersDataGridView.CurrentRow == null) return;

            var row = ((DataRowView)usersDataGridView.CurrentRow.DataBoundItem).Row;



            if (row["Role"].ToString() == "SuperAdmin")
            {
                MessageBox.Show("SuperAdmin password cannot be reset.");
                return;
            }

            string tempPassword = GenerateTemporaryPassword();

            row["PasswordHash"] = HashPassword(tempPassword);

            row["ForcePasswordChange"] = true;

            MessageBox.Show(
                $"Password has been reset.\n\nTemporary Password:\n{tempPassword}\n\nThe user will be required to change it on next login.",
                "Password Reset",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void editBtn_Click(object sender, EventArgs e)
        {

            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }

            if (usersDataGridView.CurrentRow == null)
            {
                MessageBox.Show("Please select a user first.");
                return;
            }

            var rowView = usersDataGridView.CurrentRow.DataBoundItem as DataRowView;

            if (rowView == null)
            {
                MessageBox.Show("Invalid selection.");
                return;
            }

            var row = rowView.Row;

            if (row["Role"].ToString() == "SuperAdmin")
            {
                MessageBox.Show("Access denied.");
                return;
            }

            if (isDeactivatedView)
            {
                DialogResult result = MessageBox.Show(
                    $"Are you sure you want to restore this account?\n\nUser: {row["FullName"]}",
                    "Restore Account",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result != DialogResult.Yes)
                    return;

                row["Status"] = "Active";

                MessageBox.Show("Account restored successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                ApplyUserFilters(); 
                usersDataGridView.ClearSelection();
                HideActionButtons();
                return;
            }

            using (var form = new addUserForm())
            {
                form.LoadUserData(
                    row["UserID"].ToString(),
                    row["FullName"].ToString(),
                    row["Username"].ToString(),
                    row["Email"].ToString(),
                    row["Role"].ToString(),
                    row["Status"].ToString()
                );

                if (form.ShowDialog() == DialogResult.OK)
                {
                    row["FullName"] = form.FullName;
                    row["Username"] = form.Username;
                    row["Email"] = form.Email;
                    row["Role"] = form.Role;
                    row["Status"] = form.Status;

                    ApplyUserFilters();
                }
            }


        }

        private void deleteUserBtn_Click_1(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            if (usersDataGridView.SelectedRows.Count == 0) return;

            var rowView = (DataRowView)usersDataGridView.SelectedRows[0].DataBoundItem;
            var row = rowView.Row;

            bool isRestore = isDeactivatedView;

            string actionText = isRestore ? "restore" : "deactivate";
            string titleText = isRestore ? "    Restore Account" : "Deactivate Account";

            if (row["Role"].ToString() == "SuperAdmin")
            {
                MessageBox.Show(
                    "The SuperAdmin account cannot be deactivated.",
                    "Action Not Allowed",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to {actionText} this user?\n\nUser: {row["FullName"]}",
                titleText,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result != DialogResult.Yes)
                return;

            if (!isRestore)
            {
                row["Status"] = "Deactivated";
                usersView.RowFilter = "Status = 'Active'";
            }
            else
            {
                row["Status"] = "Active";
                usersView.RowFilter = "Status = 'Deactivated'";
            }

            HideActionButtons();
            usersDataGridView.ClearSelection();
        }

        private void headerTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
