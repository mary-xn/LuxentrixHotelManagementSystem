using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public static class LoyaltyStore
    {
        public static DataTable Vouchers { get; } = CreateVouchersTable();
        public static DataTable GiftCodes { get; } = CreateGiftCodesTable();
        public static DataTable Rewards { get; } = CreateRewardsTable();

        static LoyaltyStore()
        {
            AttachLogging(Vouchers, "Loyalty / Vouchers");
            AttachLogging(GiftCodes, "Loyalty / Gift Codes");
            AttachLogging(Rewards, "Loyalty / Rewards");
        }

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

        private static DataTable CreateVouchersTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("VoucherCode");
            table.Columns.Add("RoomType");
            table.Columns.Add("Discount");
            table.Columns.Add("Date Created");
            table.Columns.Add("Dte Expiry");
            table.Columns.Add("Stocks", typeof(string));
            table.Columns.Add("Claimed", typeof(string));

            table.Rows.Add("WELCOME10-ST", "Standard", "10%","01-10-2026", "03-21-2026", "100", "25");
            table.Rows.Add("ROOM15-DX", "Deluxe", "15%", "01-10-2026", "03-21-2026", "60", "18");
            table.Rows.Add("SPA20-PR", "Premium", "20%", "01-10-2026", "03-21-2026", "40", "10");
            table.Rows.Add("VIP25-EX", "Executive", "25%", "01-10-2026", "03-21-2026", "20", "4");

            return table;
        }

        private static DataTable CreateGiftCodesTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("GiftCode");
            table.Columns.Add("Amount", typeof(decimal));
            table.Columns.Add("DateCreated", typeof(DateTime));
            table.Columns.Add("Status", typeof(string));
            table.Columns.Add("DateClaimed", typeof(DateTime));

            table.Rows.Add("GC-0001", 1000m, DateTime.Now.AddDays(-5), "Claimed", DateTime.Now.AddDays(-1));
            table.Rows.Add("GC-0002", 3000m, DateTime.Now, "Unclaimed", DBNull.Value);
            table.Rows.Add("GC-0003", 5000m, DateTime.Now, "Unclaimed", DBNull.Value);
            table.Rows.Add("GC-0004", 1000m, DateTime.Now.AddDays(-3), "Claimed", DateTime.Now.AddDays(-2));

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
