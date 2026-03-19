using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public class RoomStore
    {
        private DataTable roomsTable;
        private DataView roomsView;

        public RoomStore()
        {
            InitializeTable();
            SeedData();
            roomsView = new DataView(roomsTable);
        }

        private void InitializeTable()
        {
            roomsTable = new DataTable();

            roomsTable.Columns.Add("RoomNumber");
            roomsTable.Columns.Add("FloorNumber");
            roomsTable.Columns.Add("RoomTypeName");
            roomsTable.Columns.Add("RoomStatus");
            roomsTable.Columns.Add("Remarks");
        }

        private void SeedData()
        {
            // FLOOR 1
            roomsTable.Rows.Add("101", "1", "Standard", "Vacant", "");
            roomsTable.Rows.Add("102", "1", "Standard", "Occupied", "Late checkout");
            roomsTable.Rows.Add("103", "1", "Standard", "Vacant", "");
            roomsTable.Rows.Add("104", "1", "Standard", "Cleaning", "");
            roomsTable.Rows.Add("105", "1", "Standard", "Occupied", "");

            // FLOOR 2
            roomsTable.Rows.Add("201", "2", "Deluxe", "Cleaning", "");
            roomsTable.Rows.Add("202", "2", "Deluxe", "Vacant", "");
            roomsTable.Rows.Add("203", "2", "Deluxe", "Occupied", "");
            roomsTable.Rows.Add("204", "2", "Deluxe", "Maintenance", "TV issue");
            roomsTable.Rows.Add("205", "2", "Deluxe", "Vacant", "");

            // FLOOR 3
            roomsTable.Rows.Add("301", "3", "Suite", "Maintenance", "AC repair");
            roomsTable.Rows.Add("302", "3", "Suite", "Occupied", "");
            roomsTable.Rows.Add("303", "3", "Suite", "Vacant", "");
            roomsTable.Rows.Add("304", "3", "Suite", "Cleaning", "");
            roomsTable.Rows.Add("305", "3", "Suite", "Occupied", "");

            // FLOOR 4
            roomsTable.Rows.Add("401", "4", "Standard", "Vacant", "");
            roomsTable.Rows.Add("402", "4", "Deluxe", "Occupied", "");
            roomsTable.Rows.Add("403", "4", "Suite", "Vacant", "");
            roomsTable.Rows.Add("404", "4", "Deluxe", "Cleaning", "");
            roomsTable.Rows.Add("405", "4", "Standard", "Maintenance", "Plumbing");
        }

        // ✅ Get all rooms
        public DataView GetRooms()
        {
            roomsView.RowFilter = ""; // reset filter
            return roomsView;
        }

        // ✅ Filter by status
        public DataView FilterByStatus(string status)
        {
            roomsView.RowFilter = $"RoomStatus = '{status}'";
            return roomsView;
        }

        // ✅ Filter by type
        public DataView FilterByType(string type)
        {
            roomsView.RowFilter = $"RoomTypeName = '{type}'";
            return roomsView;
        }

        // ✅ Filter by floor
        public DataView FilterByFloor(string floor)
        {
            roomsView.RowFilter = $"FloorNumber = '{floor}'";
            return roomsView;
        }

        // ✅ Combined filter (POWERFUL 🔥)
        public DataView Filter(string status = "", string type = "", string floor = "")
        {
            string filter = "";

            if (!string.IsNullOrEmpty(status))
                filter += $"RoomStatus = '{status}'";

            if (!string.IsNullOrEmpty(type))
            {
                if (filter != "") filter += " AND ";
                filter += $"RoomTypeName = '{type}'";
            }

            if (!string.IsNullOrEmpty(floor))
            {
                if (filter != "") filter += " AND ";
                filter += $"FloorNumber = '{floor}'";
            }

            roomsView.RowFilter = filter;
            return roomsView;
        }
    }
}