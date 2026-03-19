using Microsoft.Data.SqlClient;
using LuxentrixContentManagementSystem.Database;
using LuxentrixContentManagementSystem.UserControls;

namespace LuxentrixContentManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

           //Application.Run(new LogInForm());
           Application.Run(new MainDashboard());


        }
    }
}