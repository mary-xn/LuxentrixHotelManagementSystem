using System.Data;
using System.Text;

namespace LuxentrixContentManagementSystem.Core
{
    public static class UserStore
    {
        public static DataTable Users { get; } = CreateUsersTable();

        static UserStore()
        {
            Users.RowChanged += OnRowChanged;
            Users.RowDeleted += OnRowDeleted;
        }

        private static DataTable CreateUsersTable()
        {
            DataTable table = new DataTable();

            table.Columns.Add("UserID");
            table.Columns.Add("FullName");
            table.Columns.Add("Username");
            table.Columns.Add("Email");
            table.Columns.Add("PasswordHash");
            table.Columns.Add("Role");
            table.Columns.Add("Status");
            table.Columns.Add("ForcePasswordChange", typeof(bool));

            table.Rows.Add(
                "U000",
                "System Owner",
                "superadmin",
                "admin@luxentrix.com",
                Hash("superadmin.s"),
                "SuperAdmin",
                "Active",
                false
            );

            table.Rows.Add(
                "U001",
                "Juan Dela Cruz",
                "juan.dc",
                "juan.dc@luxentrix.com",
                Hash("juan.d"),
                "Admin",
                "Active",
                false
            );

            table.Rows.Add(
                "U002",
                "Robby Loria",
                "robby.l",
                "robby.l@luxentrix.com",
                Hash("robby.l"),
                "Manager",
                "Active",
                false
            );

            return table;
        }

        private static void OnRowChanged(object sender, DataRowChangeEventArgs e)
        {
            string user = e.Row["Username"].ToString();

            if (e.Action == DataRowAction.Add)
            {
                Logger.Create("Users", $"Created user {user}");
            }
            else if (e.Action == DataRowAction.Change)
            {
                Logger.Update("Users", $"Updated user {user}");
            }
        }

        private static void OnRowDeleted(object sender, DataRowChangeEventArgs e)
        {
            Logger.Delete("Users", "Deleted a user");
        }

        private static string Hash(string password)
        {
            using var sha = System.Security.Cryptography.SHA256.Create();
            return Convert.ToBase64String(
                sha.ComputeHash(Encoding.UTF8.GetBytes(password))
            );
        }
    }
}
