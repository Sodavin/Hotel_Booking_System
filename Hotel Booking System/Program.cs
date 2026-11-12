namespace Hotel_Booking_System
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "--init-db")
            {
                DatabaseHelper.InitializeDatabase();
                return;
            }

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Initialize MySQL tables and seed data if not yet present
            DatabaseHelper.InitializeDatabase();

            Application.Run(new Form1());
        }
    }
}