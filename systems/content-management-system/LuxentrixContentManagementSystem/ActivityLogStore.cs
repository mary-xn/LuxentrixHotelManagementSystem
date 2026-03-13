using System;
using System.Data;

namespace LuxentrixContentManagementSystem.Core
{
    public static class ActivityLogStore
    {
        public static DataTable Table { get; } = CreateTable();

        private static DataTable CreateTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Timestamp", typeof(DateTime));
            table.Columns.Add("FullName");
            table.Columns.Add("Username");
            table.Columns.Add("Action");
            table.Columns.Add("Module");
            table.Columns.Add("Description");

            return table;
        }
    }
}
