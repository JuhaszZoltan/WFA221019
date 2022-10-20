namespace WFA221019
{
    internal static class Program
    {
        internal const string ConnectionString =
            "Server = (localdb)\\MSSQLLocalDB;" +
            "Database = jadijasok;";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}