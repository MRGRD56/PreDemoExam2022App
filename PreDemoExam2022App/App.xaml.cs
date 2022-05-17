using PreDemoExam2022App.Windows.MainWindow;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace PreDemoExam2022App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static new MainWindow MainWindow => (MainWindow)Current.MainWindow;
        public static Frame NavigationFrame => MainWindow.MainFrame;
    }
}
