using OutlookMiner.Models;
using OutlookMiner.Services;

namespace OutlookMiner
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
            IPathUtilityService pathUtilityService = new PathUtilityService();
            ILoadService loadService = new LoadService();
            List<Text> _mails = new List<Text>();
            Application.Run(new Form1(pathUtilityService, loadService));
            
        }
    }
}