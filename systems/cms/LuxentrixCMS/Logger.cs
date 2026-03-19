using System;

namespace LuxentrixContentManagementSystem.Core
{
    public static class Logger
    {
        public static void Log(
            string action,
            string module,
            string description
        )
        {
            ActivityLogStore.Table.Rows.Add(
                DateTime.Now,
                UserSession.FullName ?? "SYSTEM",
                UserSession.Username ?? "SYSTEM",
                action,
                module,
                description
            );
        }

        public static void Create(string module, string description)
            => Log("CREATE", module, description);

        public static void Update(string module, string description)
            => Log("UPDATE", module, description);

        public static void Delete(string module, string description)
            => Log("DELETE", module, description);
    }
}
