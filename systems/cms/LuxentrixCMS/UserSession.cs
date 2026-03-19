namespace LuxentrixContentManagementSystem.Core
{
    public static class UserSession
    {
        public static string UserID { get; set; }
        public static string FullName { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static bool ForcePasswordChange { get; set; }

        public static void Clear()
        {
            UserID = null;
            FullName = null;
            Username = null;
            Role = null;
            ForcePasswordChange = false;
        }
    }
}
