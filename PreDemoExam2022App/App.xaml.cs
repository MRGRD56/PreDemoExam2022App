using PreDemoExam2022App.Windows.MainWindow;
using System.Windows;
using System.Windows.Controls;
using PreDemoExam2022App.Common.Repository;
using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Services;
using PreDemoExam2022App.Common.Common;

namespace PreDemoExam2022App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new MainWindow MainWindow => (MainWindow)Current.MainWindow;
        public static Frame NavigationFrame => MainWindow.MainFrame;

        private static readonly DatabaseInitializationService DatabaseInitializationService = Singleton<DatabaseInitializationService>.GetInstance();

        static App()
        {
            DatabaseInitializationService.InitializeDatabase();
        }
    }
}
