using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Model
{
    public class User : BaseEntity, ICloneable
    {
        private string _login;
        private string _password;
        private string _fullName;
        private byte[] _photo;
        private Role _role;

        public User()
        {
        }

        public User(string login, string password, string fullName, byte[] photo, Role role)
        {
            Login = login;
            Password = password;
            FullName = fullName;
            Photo = photo;
            Role = role;
        }

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                _fullName = value;
                OnPropertyChanged();
            }
        }

        public byte[] Photo
        {
            get => _photo;
            set
            {
                _photo = value;
                OnPropertyChanged();
            }
        }

        public Role Role
        {
            get => _role;
            set
            {
                _role = value;
                OnPropertyChanged();
            }
        }

        public object Clone()
        {
            var user = new User(Login, Password, FullName, Photo, Role);
            user.Id = Id;
            return user;
        }
    }
}
