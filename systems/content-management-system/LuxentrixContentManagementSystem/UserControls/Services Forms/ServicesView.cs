using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.Forms.Room_Services_Forms
{
    public partial class ServicesView : UserControl
    {
        private DataTable servicesTable;

        public ServicesView()
        {
            InitializeComponent();
            this.Load += RoomServices_Load;
        }

        private void RoomServices_Load(object sender, EventArgs e)
        {
         //   StyleServicesGrid();
            LoadServices();
        }

        private void LoadServices()
        {
            servicesTable = new DataTable();

            servicesTable.Columns.Add("ServiceID", typeof(int));
            servicesTable.Columns.Add("ServiceName");
            servicesTable.Columns.Add("Category");
            servicesTable.Columns.Add("Price", typeof(decimal));
            servicesTable.Columns.Add("Availability");
            servicesTable.Columns.Add("Status");

            int id = 1;

            servicesTable.Rows.Add(id++, "In-room Massage", "Wellness", 1500, "Available", "Active");
            servicesTable.Rows.Add(id++, "Spa Treatment", "Wellness", 2500, "Available", "Active");
            servicesTable.Rows.Add(id++, "Sauna Access", "Wellness", 800, "Available", "Active");

            servicesTable.Rows.Add(id++, "Room Cleaning", "Housekeeping", 300, "Available", "Active");
            servicesTable.Rows.Add(id++, "Towel Replacement", "Housekeeping", 150, "Available", "Active");
            servicesTable.Rows.Add(id++, "Linen Change", "Housekeeping", 250, "Available", "Active");
            servicesTable.Rows.Add(id++, "Extra Pillows", "Housekeeping", 100, "Available", "Active");

            servicesTable.Rows.Add(id++, "Regular Laundry", "Laundry", 400, "Available", "Active");
            servicesTable.Rows.Add(id++, "Dry Cleaning", "Laundry", 600, "Available", "Active");
            servicesTable.Rows.Add(id++, "Ironing Service", "Laundry", 200, "Available", "Active");

            servicesTable.Rows.Add(id++, "Birthday Setup", "Special Requests", 2000, "Available", "Active");
            servicesTable.Rows.Add(id++, "Romantic Setup", "Special Requests", 3000, "Available", "Active");
            servicesTable.Rows.Add(id++, "Decoration Setup", "Special Requests", 2500, "Available", "Active");

         //   servicesDataGridView.DataSource = servicesTable;

          //  roomServicesCategoryComboBox.Items.Clear();
            //roomServicesCategoryComboBox.Items.Add("All");
          //  roomServicesCategoryComboBox.Items.Add("Wellness");
            //roomServicesCategoryComboBox.Items.Add("Housekeeping");
            //romServicesCategoryComboBox.Items.Add("Laundry");
            //roomServicesCategoryComboBox.Items.Add("Special Requests");
           // roomServicesCategoryComboBox.SelectedIndex = 0;
        }

        private void ApplyFilters()
        {
            if (servicesTable == null) return;

            List<string> filters = new List<string>();
        //    string searchText = searchServicesTxtBox.Text.Trim().Replace("'", "''");

           // if (!string.IsNullOrWhiteSpace(searchText))
            {
              //  filters.Add($@"
             //   (
             //       Convert(ServiceID, 'System.String') LIKE '%{searchText}%'
              //      OR ServiceName LIKE '%{searchText}%'
              //      OR Category LIKE '%{searchText}%'
             //       OR Convert(Price, 'System.String') LIKE '%{searchText}%'
             //       OR Availability LIKE '%{searchText}%'
              //      OR Status LIKE '%{searchText}%'
              //  )");
            }

           // if (roomServicesCategoryComboBox.SelectedIndex > 0)
           // {
               // filters.Add(
          ///          $"Category = '{roomServicesCategoryComboBox.Text.Replace("'", "''")}'");
           // }

           // servicesTable.DefaultView.RowFilter = string.Join(" AND ", filters);
        }

       // private void StyleServicesGrid()
      //  {
            //var grid = servicesDataGridView;

           // grid.Dock = DockStyle.Fill;
          //  grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
           // grid.RowTemplate.Height = 38;

           // grid.ThemeStyle.HeaderStyle.Height = 40;
          //  grid.ThemeStyle.HeaderStyle.Font =
          //      new Font("Segoe UI", 10F, FontStyle.Bold);
          //  grid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(133, 102, 84);
          //  grid.ThemeStyle.HeaderStyle.ForeColor = Color.White;

          //  grid.ThemeStyle.RowsStyle.SelectionBackColor =
          //      Color.FromArgb(208, 189, 172);

         //   grid.RowHeadersVisible = false;
          //  grid.ReadOnly = true;
           // grid.AllowUserToAddRows = false;

           // typeof(DataGridView)
           //     .GetProperty("DoubleBuffered",
           //         System.Reflection.BindingFlags.Instance |
             //       System.Reflection.BindingFlags.NonPublic)!
         //       .SetValue(grid, true, null);
      //  }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchRoomServicesTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void roomServicesCategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void addServicesBtn_Click(object sender, EventArgs e)
        {
        }

        private void roomServicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
