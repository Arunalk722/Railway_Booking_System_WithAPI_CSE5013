using SLRD_ClientApp.Properties;

namespace SLRD_ClientApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginClient());
        }
    }
}