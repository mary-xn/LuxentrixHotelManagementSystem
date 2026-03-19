using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using LuxentrixContentManagementSystem.Core;

namespace LuxentrixContentManagementSystem.UserControls.Activity_Logs
{
    public partial class ActivityLog : UserControl
    {
        private DataView logView;

        public ActivityLog()
        {
            InitializeComponent();
            Load += ActivityLog_Load;
        }

        private void ActivityLog_Load(object sender, EventArgs e)
        {
            StyleRoomsGrid();
            LoadLogs();
        }

        private void LoadLogs()
        {
            activityLogDataGridView.AutoGenerateColumns = false;
            activityLogDataGridView.Columns.Clear();

            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Timestamp",
                HeaderText = "Date & Time"
            });
            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FullName",
                HeaderText = "Full Name"
            });

            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Username",
                HeaderText = "User"
            });

            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Module",
                HeaderText = "Module"
            });

            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Action",
                HeaderText = "Action"
            });

            activityLogDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            logView = new DataView(ActivityLogStore.Table);
            activityLogDataGridView.DataSource = logView;
        }

        private void ApplyFilter()
        {
            if (logView == null) return;

            string searchText = searchTxtBox.Text.Trim().Replace("'", "''");

            if (string.IsNullOrWhiteSpace(searchText))
            {
                logView.RowFilter = string.Empty;
                return;
            }

            logView.RowFilter = $@"
            (
                User LIKE '%{searchText}%'
                OR Module LIKE '%{searchText}%'
                OR Action LIKE '%{searchText}%'
                OR Description LIKE '%{searchText}%'
                OR Timestamp LIKE '%{searchText}%'
            )";
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void activityLogDataGridView_CellContentClick(
            object sender,
            DataGridViewCellEventArgs e
        )
        { }

        private void StyleRoomsGrid()
        {
            var grid = activityLogDataGridView;

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
                .GetProperty(
                    "DoubleBuffered",
                    System.Reflection.BindingFlags.Instance |
                    System.Reflection.BindingFlags.NonPublic
                )!
                .SetValue(grid, true, null);
        }
    }
}
