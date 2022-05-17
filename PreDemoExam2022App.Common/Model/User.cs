using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Model
{
    public class User : BaseEntity
    {
        public User()
        {
        }

        public User(string login, string password, string fullName)
        {
            Login = login;
            Password = password;
            FullName = fullName;
        }

        public string Login { get; set; }
        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
