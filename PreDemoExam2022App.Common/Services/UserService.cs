using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Repository;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Services
{
    public class UserService
    {
        private readonly DatabaseContext _db = DatabaseContext.Create();

        public UserService()
        {
            if (!_db.Users.Any())
            {
                _db.Users.Add(new User("admin", "123123", "Иванов Сергей Петрович"));
                _db.SaveChanges();
            }
        }

        public Task<User> GetUserByCredentialsAsync(string login, string password)
        {
            return _db.Users.FirstOrDefaultAsync(user => (
                string.Equals(user.Login, login, StringComparison.InvariantCultureIgnoreCase)
                    && string.Equals(user.Password, password, StringComparison.InvariantCultureIgnoreCase)
            ));
        }
    }
}
