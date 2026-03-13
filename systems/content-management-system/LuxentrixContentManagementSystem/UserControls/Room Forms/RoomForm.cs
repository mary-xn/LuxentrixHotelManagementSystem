using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LuxentrixContentManagementSystem.Database;

namespace LuxentrixContentManagementSystem.Forms
{
    public partial class RoomForm : Form
    {
        private DataTable roomsTable = new DataTable();
        private DataView roomsView;

        public RoomForm()
        {
            InitializeComponent();
            this.Load += RoomForm_LoadAsync;
        }

        private async void RoomForm_LoadAsync(object? sender, EventArgs e)
        {
            SetupGridColumns();
            StyleRoomsGrid();
            LoadStatusComboBox();
            LoadRoomTypeComboBox();

            headerTableLayoutPanel.SuspendLayout();
            headerTableLayoutPanel.ResumeLayout();

            await LoadRoomsAsync();
        }

        private async Task LoadRoomsAsync()
        {
            DataTable tempTable = new DataTable();

            await Task.Run(() =>
            {
                using (SqlConnection conn = DbConnection.GetConnection())
                {
                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(@"
                        SELECT
                            r.RoomID,
                            r.RoomNumber,
                            r.FloorNumber,
                            rt.RoomTypeName,
                            r.RoomStatus,
                            r.Remarks
                        FROM Rooms r
                        INNER JOIN RoomTypeRates rt
                            ON r.RoomTypeID = rt.RoomTypeID;", conn);

                    da.Fill(tempTable);
                }
            });

            roomsTable.Clear();
            roomsTable.Merge(tempTable);

            roomsView = new DataView(roomsTable);

            roomsDataGridView.AutoGenerateColumns = false;

            roomsDataGridView.SuspendLayout();
            roomsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            roomsDataGridView.ResumeLayout();
        }

        private void ApplyFilters()
        {
            if (roomsView == null) return;

            List<string> filters = new List<string>();

            string searchText = searchRoomTxtBox.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filters.Add($@"
                (
                    Convert(RoomID, 'System.String') LIKE '%{searchText}%'
                    OR Convert(RoomNumber, 'System.String') LIKE '%{searchText}%'
                    OR Convert(FloorNumber, 'System.String') LIKE '%{searchText}%'
                    OR RoomTypeName LIKE '%{searchText}%'
                    OR RoomStatus LIKE '%{searchText}%'
                    OR Remarks LIKE '%{searchText}%'
                )");
            }

            if (statusComboBox.SelectedIndex > 0)
            {
                filters.Add(
                    $"RoomStatus = '{statusComboBox.SelectedItem.ToString()!.Replace("'", "''")}'");
            }

            if (roomTypeComboBox.SelectedIndex > 0)
            {
                filters.Add(
                    $"RoomTypeName = '{roomTypeComboBox.SelectedItem.ToString()!.Replace("'", "''")}'");
            }

            roomsView.RowFilter = string.Join(" AND ", filters);
        }

        private void LoadStatusComboBox()
        {
            statusComboBox.Items.Clear();
            statusComboBox.Items.Add("All");
            statusComboBox.Items.Add("Vacant");
            statusComboBox.Items.Add("Cleaning");
            statusComboBox.Items.Add("Maintenance");
            statusComboBox.SelectedIndex = 0;
        }

        private void LoadRoomTypeComboBox()
        {
            using (SqlConnection conn = DbConnection.GetConnection())
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter(
                    "SELECT RoomTypeName FROM RoomTypeRates", conn);

                DataTable dt = new DataTable();
                da.Fill(dt);

                roomTypeComboBox.Items.Clear();
                roomTypeComboBox.Items.Add("All");

                foreach (DataRow row in dt.Rows)
                {
                    roomTypeComboBox.Items.Add(row["RoomTypeName"].ToString());
                }

                roomTypeComboBox.SelectedIndex = 0;
            }
        }

        private void StyleRoomsGrid()
        {
            var grid = roomsDataGridView;

            grid.SuspendLayout();

            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
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

            grid.ResumeLayout();
        }

        private void SetupGridColumns()
        {
            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.Columns.Clear();

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomID",
                HeaderText = "ID",
                Width = 60
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomNumber",
                HeaderText = "Room No."
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "FloorNumber",
                HeaderText = "Floor"
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomTypeName",
                HeaderText = "Type"
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomStatus",
                HeaderText = "Status"
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Remarks",
                HeaderText = "Remarks"
            });
        }

        private void roomsDataGridView_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (roomsDataGridView.Columns[e.ColumnIndex].Name == "RoomStatus"
                && e.Value != null)
            {
                string status = e.Value.ToString()!;

                if (status == "Vacant")
                    e.CellStyle.ForeColor = Color.Green;
                else if (status == "Cleaning")
                    e.CellStyle.ForeColor = Color.Orange;
                else if (status == "Maintenance")
                    e.CellStyle.ForeColor = Color.Red;
            }
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchRoomTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void statusComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
        }

        private void addRoomBtn_Click_1(object sender, EventArgs e)
        {
        }

        private void roomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void roomsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void guna2ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
