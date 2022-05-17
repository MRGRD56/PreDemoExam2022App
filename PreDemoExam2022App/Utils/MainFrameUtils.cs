using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PreDemoExam2022App.Utils
{
    internal static class MainFrameUtils
    {
        public static void Navigate<T>(this Frame frame) where T : new()
        {
            frame.Navigate(Activator.CreateInstance<T>());
        }
    }
}
