using TPR_MoviesLibrary.Repositories;

namespace TPR_MoviesLibrary
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
            const string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog=Movies; Integrated Security=SSPI;";
            IRepositoryFactory factory = new SqlRepositoryFactory(connectionString);
            Application.Run(new MainForm(factory));
        }
    }
}