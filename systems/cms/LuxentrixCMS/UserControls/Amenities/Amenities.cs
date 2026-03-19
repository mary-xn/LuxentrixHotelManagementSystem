using Guna.UI2.WinForms;
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
    public partial class Amenities : Form
    {
        private DataTable amenitiesTable = new DataTable();
        private DataView amenitiesView;


        public Amenities()
        {
            InitializeComponent();
            StyleFoodMenuGrid();
            SetupGridColumns();
            LoadAmenities();
            
        }

        private void StyleFoodMenuGrid()
        {
            var grid = amenitiesDataGridView;

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
        }

        private void ResetButtons()
        {
            allBtn.FillColor = Color.FromArgb(208, 189, 172);
            allBtn.ForeColor = Color.Black;

            foodBtn.FillColor = Color.FromArgb(208, 189, 172);
            foodBtn.ForeColor = Color.Black;

            servicesBtn.FillColor = Color.FromArgb(208, 189, 172);
            servicesBtn.ForeColor = Color.Black;

            hygieneBtn.FillColor = Color.FromArgb(208, 189, 172);
            hygieneBtn.ForeColor = Color.Black;


        }

        private void SetupGridColumns()
        {
            amenitiesDataGridView.AutoGenerateColumns = false;
            amenitiesDataGridView.Columns.Clear();

            amenitiesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "ItemName",
                HeaderText = "Item"
            });

            amenitiesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Description",
                HeaderText = "Description"
            });

            amenitiesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Price",
                HeaderText = "Price"
            });

            amenitiesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Category",
                HeaderText = "Category"
            });


            amenitiesDataGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Stocks",
                HeaderText = "Stocks"
            });
        }

        private void ApplyFilters(string categoryFilter = "")
        {
            if (amenitiesView == null) return;

            List<string> filters = new List<string>();

            if (!string.IsNullOrWhiteSpace(categoryFilter))
            {
                filters.Add($"Category = '{categoryFilter}'");
            }

            string searchText = searchTxtBox.Text.Trim().Replace("'", "''");

            if (!string.IsNullOrWhiteSpace(searchText))
            {
                filters.Add($@"
        (
            ItemName LIKE '%{searchText}%'
            OR Description LIKE '%{searchText}%'
            OR Price LIKE '%{searchText}%'
            OR Stocks LIKE '%{searchText}%'
            OR Category LIKE '%{searchText}%'
        )");
            }

            amenitiesView.RowFilter = string.Join(" AND ", filters);
        }


        private void LoadAmenities()
        {
            amenitiesTable.Clear();
            amenitiesTable.Columns.Clear();

            amenitiesTable.Columns.Add("Category");
            amenitiesTable.Columns.Add("ItemName");
            amenitiesTable.Columns.Add("Description");
            amenitiesTable.Columns.Add("Price");
            amenitiesTable.Columns.Add("Stocks");

            amenitiesTable.Rows.Add("Food", "Chicharon ni Mang Juan", "90 g", "₱43.00", 10);
            amenitiesTable.Rows.Add("Food", "V-Cut Potato Chips", "60 g", "₱53.75", 10);
            amenitiesTable.Rows.Add("Food", "Cup Noodles Beef", "60 g", "₱45.75", 10);
            amenitiesTable.Rows.Add("Food", "Cup Noodles Bulalo", "60 g", "₱47.75", 10);
            amenitiesTable.Rows.Add("Food", "C2 Lemon Green Tea", "355 mL", "₱40.00", 10);
            amenitiesTable.Rows.Add("Food", "Coke Mismo", "300 mL", "₱40.00", 10);
            amenitiesTable.Rows.Add("Food", "Nescafe 3-in-1 Coffee", "35 g", "₱15.00", 10);
            amenitiesTable.Rows.Add("Food", "Summit Drinking Water", "500 mL", "₱28.50", 10);

            amenitiesTable.Rows.Add("Food", "Ginebra San Miguel", "700 mL", "₱170.85", 10);
            amenitiesTable.Rows.Add("Food", "Red Horse Beer", "500 mL", "₱70.50", 10);
            amenitiesTable.Rows.Add("Food", "San Miguel Apple", "330 mL", "₱63.75", 10);

            amenitiesTable.Rows.Add("Hygiene", "Colgate Toothbrush", "1 pc", "₱50.00", 10);
            amenitiesTable.Rows.Add("Hygiene", "Colgate Toothpaste Tube", "37 g", "₱61.50", 10);
            amenitiesTable.Rows.Add("Hygiene", "Head & Shoulders Sachet", "18 mL", "₱10.75", 10);
            amenitiesTable.Rows.Add("Hygiene", "Safeguard White Bar Soap", "55 g", "₱41.75", 10);

            amenitiesTable.Rows.Add("Service", "Massage", "30 mins", "₱899.00", "-");
            amenitiesTable.Rows.Add("Service", "Room Cleaning", "Heavy Cleaning", "₱999.00", "-");

            amenitiesView = new DataView(amenitiesTable);
            amenitiesDataGridView.DataSource = amenitiesView;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void searchTxtBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void foodBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ApplyFilters("Food");
            foodBtn.FillColor = Color.FromArgb(133, 102, 84);
            foodBtn.ForeColor = Color.White;
        }

        private void hygieneBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ApplyFilters("Hygiene");
            hygieneBtn.FillColor = Color.FromArgb(133, 102, 84);
            hygieneBtn.ForeColor = Color.White;
        }

        private void servicesBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ApplyFilters("Service");
            servicesBtn.FillColor = Color.FromArgb(133, 102, 84);
            servicesBtn.ForeColor = Color.White;
        }

        private void amenitiesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void allBtn_Click(object sender, EventArgs e)
        {
            ResetButtons();
            ApplyFilters();
            allBtn.FillColor = Color.FromArgb(133, 102, 84);
            allBtn.ForeColor = Color.White;
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void headerTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {

            overlayForm overlay = new overlayForm();
            overlay.Show(); 

            using (addAmenityForm addForm = new addAmenityForm())
            {
                addForm.StartPosition = FormStartPosition.CenterScreen;

                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAmenities();
                }
            }

            overlay.Close(); 
        }

        private void overlayPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
