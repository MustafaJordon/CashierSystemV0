using static System.Configuration.ConfigurationManager;
namespace cashierSystem_v0
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        static public string connectionString = ConnectionStrings["connectionString"].ConnectionString;
        static public int PuserID = 0;
        static public string? Prole = "";
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new loginForm());
        }
    }
}