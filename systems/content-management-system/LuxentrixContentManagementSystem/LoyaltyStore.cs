using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public static class LoyaltyStore
    {
        public static DataTable Vouchers { get; } = CreateVouchersTable();
        public static DataTable GiftCodes { get; } = CreateGiftCodesTable();
        public static DataTable Rewards { get; } = CreateRewardsTable();

        // ✅ AUTO-LOGGER (added)
        static LoyaltyStore()
        {
            AttachLogging(Vouchers, "Loyalty / Vouchers");
            AttachLogging(GiftCodes, "Loyalty / Gift Codes");
            AttachLogging(Rewards, "Loyalty / Rewards");
        }

        // ✅ shared logging logic
        private static void AttachLogging(DataTable table, string module)
        {
            table.RowChanged += (s, e) =>
            {
                if (e.Action == DataRowAction.Add)
                    Logger.Log(module, "CREATE", "New record added");

                else if (e.Action == DataRowAction.Change)
                    Logger.Log(module, "UPDATE", "Record updated");
            };

            table.RowDeleted += (s, e) =>
            {
                Logger.Log(module, "DELETE", "Record deleted");
            };
        }

        // =========================
        // YOUR ORIGINAL CODE (UNCHANGED)
        // =========================
        private static DataTable CreateVouchersTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("VoucherCode");
            table.Columns.Add("RoomType");
            table.Columns.Add("Discount");
            table.Columns.Add("Stocks", typeof(string));
            table.Columns.Add("Claimed", typeof(string));

            table.Rows.Add("WELCOME10-ST", "Standard", "10%", "100", "25");
            table.Rows.Add("ROOM15-DX", "Deluxe", "15%", "60", "18");
            table.Rows.Add("SPA20-PR", "Premium", "20%", "40", "10");
            table.Rows.Add("VIP25-EX", "Executive", "25%", "20", "4");

            return table;
        }

        private static DataTable CreateGiftCodesTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("GiftCode");
            table.Columns.Add("RoomType");
            table.Columns.Add("HoursStay");
            table.Columns.Add("Discount");
            table.Columns.Add("Stocks", typeof(string));
            table.Columns.Add("Claimed", typeof(string));

            table.Rows.Add("GC-ST-3H", "Standard", "3", "100%", "20", "5");
            table.Rows.Add("GC-ST-6H", "Standard", "6", "100%", "15", "3");
            table.Rows.Add("GC-DX-12H", "Deluxe", "12", "100%", "10", "2");
            table.Rows.Add("GC-DX-24H", "Deluxe", "24", "100%", "8", "1");

            return table;
        }

        private static DataTable CreateRewardsTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("PointsRequired");
            table.Columns.Add("Discount");
            table.Columns.Add("Description");

            table.Rows.Add("500", "5%", "One-time");
            table.Rows.Add("1000", "10%", "One-time");
            table.Rows.Add("2000", "20%", "One-time");
            table.Rows.Add("3000", "25%", "Multiple-use");

            return table;
        }
    }
}
