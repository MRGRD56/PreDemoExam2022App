using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Services
{
    public class UserService
    {
        private readonly DatabaseContext _db = new();

        public List<User> GetUsers()
        {
            _db.Roles.Load();
            return _db.Users.ToList();
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            return await _db.Users.FindAsync(new object[] {id});
        }

        public async Task<List<User>> GetUsersAsync()
        {
            await _db.Roles.LoadAsync();
            return await _db.Users.ToListAsync();
        }

        public async Task<User> AddUserAsync(User user)
        {
            await _db.Users.AddAsync(user);
            await _db.SaveChangesAsync();
            return user;
        }

        public async Task<User> SaveUserAsync(User user)
        {
            //_db.Users.Update(user);
            //await _db.SaveChangesAsync();
            //return user;
            var dbUser = await GetUserByIdAsync(user.Id);
            dbUser.Login = user.Login;
            dbUser.Password = user.Password;
            dbUser.FullName = user.FullName;
            dbUser.Photo = user.Photo;
            dbUser.Role = user.Role;
            dbUser.IsDeleted = user.IsDeleted;
            await _db.SaveChangesAsync();

            return user;
        }

        public async Task DeleteUserAsync(User user)
        {
            _db.Remove(user);
            await _db.SaveChangesAsync();
        }

        public Task<User> GetUserByCredentialsAsync(string login, string password)
        {
            return _db.Users.FirstOrDefaultAsync(user => (
                user.Login.ToLower() == login.ToLower()
                    && user.Password.ToLower() == password.ToLower()
            ));
        }
    }
}
