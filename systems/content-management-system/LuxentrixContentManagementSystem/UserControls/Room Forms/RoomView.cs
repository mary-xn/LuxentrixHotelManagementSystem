using Guna.UI2.WinForms;
using LuxentrixContentManagementSystem.Core;
using LuxentrixContentManagementSystem.Database;
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

namespace LuxentrixContentManagementSystem.Forms.Room_Forms
{
    public partial class RoomView : UserControl
    {
        private DataTable roomsTable = new DataTable();
        private DataView roomsView;
        private DataTable roomTypesTable = RoomTypeStore.Table;
        private bool isRoomTypesView = false;

        public RoomView()
        {
            InitializeComponent();
            this.Load += RoomView_Load;
            roomsDataGridView.SelectionChanged += roomsDataGridView_SelectionChanged;
        }

        private void RoomView_Load(object? sender, EventArgs e)
        {
            SetupGridColumns();
            StyleRoomsGrid();
            LoadStatusComboBox();
            LoadRoomTypeComboBox();
            LoadRooms();
            addRoomBtn.Visible = false;
            deleteRoomTypeBtn.Visible = false;

        }

        private void LoadRooms()
        {
            isRoomTypesView = false;

            roomsDataGridView.Columns.Clear();
            SetupGridColumns();

            roomsTable.Clear();
            roomsTable.Columns.Clear();

            roomsTable.Columns.Add("RoomNumber");
            roomsTable.Columns.Add("FloorNumber");
            roomsTable.Columns.Add("RoomTypeName");
            roomsTable.Columns.Add("RoomStatus");
            roomsTable.Columns.Add("Remarks");

            roomsTable.Rows.Add("101", "1", "Standard", "Vacant", "");
            roomsTable.Rows.Add("102", "1", "Standard", "Occupied", "Late checkout");
            roomsTable.Rows.Add("201", "2", "Deluxe", "Cleaning", "");
            roomsTable.Rows.Add("202", "2", "Deluxe", "Vacant", "");
            roomsTable.Rows.Add("301", "3", "Suite", "Maintenance", "AC repair");
            roomsTable.Rows.Add("302", "3", "Suite", "Occupied", "");

            roomsView = new DataView(roomsTable);
            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.DataSource = roomsView;
        }



        private void LoadRoomTypeComboBox()
        {
            roomTypeComboBox.Items.Clear();
            roomTypeComboBox.Items.Add("All");
            roomTypeComboBox.Items.Add("Standard");
            roomTypeComboBox.Items.Add("Deluxe");
            roomTypeComboBox.Items.Add("Suite");
            roomTypeComboBox.SelectedIndex = 0;
        }

        private void LoadRoomTypes()
        {
            isRoomTypesView = true;

            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.Columns.Clear();

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "RoomType",
                HeaderText = "Room Type"
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Theme",
                HeaderText = "Theme"
            });

            roomsDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stock",
                HeaderText = "Room Stock"
            });

            roomsView = new DataView(Core.RoomTypeStore.Table);
            roomsDataGridView.DataSource = roomsView;
        }



        private void ApplyFilters()
        {
            if (roomsView == null) return;

            List<string> filters = new List<string>();
            string searchText = searchRoomTxtBox.Text.Trim().Replace("'", "''");

            if (isRoomTypesView)
            {
                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    filters.Add(
                        $"(" +
                        $"RoomType LIKE '%{searchText}%' OR " +
                        $"Theme LIKE '%{searchText}%' OR " +
                        $"Stock LIKE '%{searchText}%'" +
                        $")"
                    );
                }

                roomsView.RowFilter = filters.Count == 0
                    ? null
                    : string.Join(" AND ", filters);

                return;
            }

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filters.Add(
                    $"(" +
                    $"RoomNumber LIKE '%{searchText}%' OR " +
                    $"FloorNumber LIKE '%{searchText}%' OR " +
                    $"RoomTypeName LIKE '%{searchText}%' OR " +
                    $"RoomStatus LIKE '%{searchText}%' OR " +
                    $"Remarks LIKE '%{searchText}%'" +
                    $")"
                );
            }

            if (statusComboBox.SelectedIndex > 0)
            {
                filters.Add(
                    $"RoomStatus = '{statusComboBox.Text.Replace("'", "''")}'"
                );
            }

            if (roomTypeComboBox.SelectedIndex > 0)
            {
                filters.Add(
                    $"RoomTypeName = '{roomTypeComboBox.Text.Replace("'", "''")}'"
                );
            }

            // ✅ IMPORTANT FIX
            roomsView.RowFilter = filters.Count == 0
                ? null
                : string.Join(" AND ", filters);
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

        private void StyleRoomsGrid()
        {
            var grid = roomsDataGridView;

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

        private void SetupGridColumns()
        {
            roomsDataGridView.AutoGenerateColumns = false;
            roomsDataGridView.Columns.Clear();

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchRoomTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void roomTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            using (var addRoomForm = new AddRoomForm(roomTypesTable))
            {
                if (addRoomForm.ShowDialog() == DialogResult.OK)
                {
                    roomsDataGridView.Refresh();
                }
            }
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

        private void UpdateControlVisibility()
        {
            if (isRoomTypesView)
            {
                addRoomBtn.Visible = true;
                statusComboBox.Visible = false;
                statusLabel.Visible = false;
            }
            else
            {
                addRoomBtn.Visible = false;
                statusComboBox.Visible = true;
            }
        }

        private void roomsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            deleteRoomTypeBtn.Enabled = true;
            deleteRoomTypeBtn.Visible = true;
            if (roomsDataGridView.CurrentRow == null)
            {
                return;
            }

            var row = ((DataRowView)roomsDataGridView.CurrentRow.DataBoundItem).Row;

        }


        private void headerTableLayoutPanel_Paint(object sender, PaintEventArgs e) { }
        private void mainPanel_Paint(object sender, PaintEventArgs e) { }
        private void headerPanel_Paint(object sender, PaintEventArgs e) { }
        private void gridPanel_Paint(object sender, PaintEventArgs e) { }

        private void roomTypesBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadRoomTypes();
            UpdateControlVisibility();
            roomTypesBtn.FillColor = Color.FromArgb(133, 102, 84);
            roomTypesBtn.ForeColor = Color.White;
        }
        private void roomsBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            LoadRooms();
            UpdateControlVisibility();
            roomsBtn.FillColor = Color.FromArgb(133, 102, 84);
            roomsBtn.ForeColor = Color.White;

        }

        private void tagsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roomsDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void roomTypeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void deleteRoomTypeBtn_Click(object sender, EventArgs e)
        {
            if (!AccessControl.HasAccess(Roles.SuperAdmin, Roles.Admin))
            {
                MessageBox.Show("Access denied.");
                return;
            }
            if (roomsDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            DataRowView rowView =
                (DataRowView)roomsDataGridView.SelectedRows[0].DataBoundItem;

            rowView.Row.Delete();
        }

        private void roomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
