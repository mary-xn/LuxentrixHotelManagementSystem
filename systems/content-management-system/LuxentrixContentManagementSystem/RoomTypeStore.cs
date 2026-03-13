using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public static class RoomTypeStore
    {
        public static DataTable Table { get; } = CreateTable();

        static RoomTypeStore()
        {
            Table.RowChanged += OnRowChanged;
            Table.RowDeleted += OnRowDeleted;
        }

        private static DataTable CreateTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("RoomType");
            table.Columns.Add("Theme");
            table.Columns.Add("Stock");


            table.Rows.Add("Standard", "Classic", 20);
            table.Rows.Add("Deluxe", "Modern", 15);
            table.Rows.Add("Premium", "Luxury", 10);
            table.Rows.Add("Executive", "Business", 5);

            return table;
        }

        private static void OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            if (e.Action == DataRowAction.Add)
            {
                Logger.Create(
                    "Room Types",
                    $"Added room type {e.Row["RoomType"]}"
                );
            }
            else if (e.Action == DataRowAction.Change)
            {
                Logger.Update(
                    "Room Types",
                    $"Updated room type {e.Row["RoomType"]}"
                );
            }
        }

        private static void OnRowDeleted(object sender, DataRowChangeEventArgs e)
        {
            Logger.Delete(
                "Room Types",
                "Deleted a room type"
            );
        }
    }
}
