using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace PreDemoExam2022App.Windows.UserEditWindow
{
    /// <summary>
    /// Логика взаимодействия для UserEditWindow.xaml
    /// </summary>
    public partial class UserEditWindow : Window
    {
        private UserEditWindowViewModel ViewModel => this.GetDataContext<UserEditWindowViewModel>();

        public UserEditWindow()
        {
            InitializeComponent();
        }

        public UserEditWindow(User user)
        {
            InitializeComponent();
            ViewModel.User = user;
        }
    }
}
