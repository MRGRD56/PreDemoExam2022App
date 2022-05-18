using Microsoft.EntityFrameworkCore;
using PreDemoExam2022App.Common.Model;
using PreDemoExam2022App.Common.Repository;
using PreDemoExam2022App.Common.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Services
{
    public class DatabaseInitializationService
    {
        public void InitializeDatabase()
        {
            var db = new DatabaseContext();
            db.Database.Migrate();

            var adminRole = db.Roles.FirstOrNew(role => role.Name == "Admin", () => new Role("Admin"));
            var userRole = db.Roles.FirstOrNew(role => role.Name == "User", () => new Role("User"));
            db.SaveChanges();

            if (!db.Users.Any())
            {
                db.Users.Add(new User("admin", "123123", "Иванов Сергей Петрович", null, adminRole));
                db.SaveChanges();
            }
        }
    }
}
