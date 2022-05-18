using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Windows.UserEditWindow
{
    internal class UserEditWindowViewModel : ViewModel
    {
        private User _user;

        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged();
            }
        }

        public UserEditWindowViewModel()
        {
            _user = new User("", "", "", null, null);
        }

        public UserEditWindowViewModel(User user)
        {
            _user = user;
        }
    }
}
