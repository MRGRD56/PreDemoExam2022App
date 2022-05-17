using System.Windows;

namespace PreDemoExam2022App.Utils
{
    internal static class WindowUtils
    {
        public static T GetDataContext<T>(this Window window) => (T)window.DataContext;
    }
}
