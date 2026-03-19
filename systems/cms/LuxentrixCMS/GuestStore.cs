using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public class GuestStore
    {
        private DataTable guestsTable;
        private DataView guestsView;

        public GuestStore()
        {
            InitializeTable();
            SeedData();
            guestsView = new DataView(guestsTable);
        }

        private void InitializeTable()
        {
            guestsTable = new DataTable();

            guestsTable.Columns.Add("RoomNumber");
            guestsTable.Columns.Add("FloorNumber");
            guestsTable.Columns.Add("RoomTypeName");
            guestsTable.Columns.Add("CheckInStatus"); // Checked-in / Checked-out
            guestsTable.Columns.Add("StayStatus");    // Active / Late / Extended
        }

        private void SeedData()
        {
            // Only occupied rooms (since these have guests)

            guestsTable.Rows.Add("102", "1", "Standard", "Checked-in", "Late");
            guestsTable.Rows.Add("105", "1", "Standard", "Checked-in", "Active");

            guestsTable.Rows.Add("203", "2", "Deluxe", "Checked-in", "Active");

            guestsTable.Rows.Add("302", "3", "Suite", "Checked-in", "Active");
            guestsTable.Rows.Add("305", "3", "Suite", "Checked-in", "Active");

            guestsTable.Rows.Add("402", "4", "Deluxe", "Checked-in", "Active");
        }

        // ✅ Get all guests
        public DataView GetGuests()
        {
            guestsView.RowFilter = "";
            return guestsView;
        }

        // ✅ Filter by room type
        public DataView FilterByType(string type)
        {
            guestsView.RowFilter = $"RoomTypeName = '{type}'";
            return guestsView;
        }

        // ✅ Filter by floor
        public DataView FilterByFloor(string floor)
        {
            guestsView.RowFilter = $"FloorNumber = '{floor}'";
            return guestsView;
        }

        // ✅ Filter by stay status
        public DataView FilterByStayStatus(string stayStatus)
        {
            guestsView.RowFilter = $"StayStatus = '{stayStatus}'";
            return guestsView;
        }

        // ✅ Combined filter (like RoomStore)
        public DataView Filter(string type = "", string floor = "", string stayStatus = "")
        {
            string filter = "";

            if (!string.IsNullOrEmpty(type))
                filter += $"RoomTypeName = '{type}'";

            if (!string.IsNullOrEmpty(floor))
            {
                if (filter != "") filter += " AND ";
                filter += $"FloorNumber = '{floor}'";
            }

            if (!string.IsNullOrEmpty(stayStatus))
            {
                if (filter != "") filter += " AND ";
                filter += $"StayStatus = '{stayStatus}'";
            }

            guestsView.RowFilter = filter;
            return guestsView;
        }

        // ✅ Search (optional)
        public DataView Search(string keyword)
        {
            guestsView.RowFilter = $"RoomNumber LIKE '%{keyword}%'";
            return guestsView;
        }
    }
}