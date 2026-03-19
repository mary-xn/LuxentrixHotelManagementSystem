using LuxentrixContentManagementSystem.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuxentrixContentManagementSystem.UserControls.MainDashBoard.View_Forms
{
    public partial class ViewVacant : Form
    {
        private Form overlay;
        private RoomStore roomStore;
        public ViewVacant(Form overlayForm)
        {
            InitializeComponent();
            StyleRoomsGrid();
            SetupGridColumns();
            overlay = overlayForm;
            this.CenterToParent();
            roomStore = new RoomStore();
            roomsDataGridView.DataSource = roomStore.GetRooms();
            roomsDataGridView.DataSource = roomStore.FilterByStatus("Vacant");
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void StyleRoomsGrid()
        {
            var grid = roomsDataGridView;

            grid.SuspendLayout();

            grid.Dock = DockStyle.None;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            grid.RowTemplate.Height = 38;

            grid.ThemeStyle.HeaderStyle.Height = 40;
            grid.ThemeStyle.HeaderStyle.Font =
                new Font("Segoe UI", 16F, FontStyle.Bold);
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

        private void roomsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
