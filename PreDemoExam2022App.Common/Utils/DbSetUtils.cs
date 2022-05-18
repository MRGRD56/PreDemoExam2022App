using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PreDemoExam2022App.Common.Utils
{
    public static class DbSetUtils
    {
        public static T FirstOrNew<T>(this DbSet<T> dbSet, Expression<Func<T, bool>> predicate, Func<T> newEntityCreation, Action<T> afterCreation = null) where T : class
        {
            var entity = dbSet.FirstOrDefault(predicate);
            if (entity != null)
            {
                return entity;
            }

            entity = dbSet.Add(newEntityCreation()).Entity;
            afterCreation?.Invoke(entity);

            return entity;
        }

        public static async Task<T> FirstOrNewAsync<T>(this DbSet<T> dbSet, Expression<Func<T, bool>> predicate, Func<T> newEntityCreation, Action<T> afterCreation = null) where T : class
        {
            var entity = await dbSet.FirstOrDefaultAsync(predicate);
            if (entity != null)
            {
                return entity;
            }

            entity = (await dbSet.AddAsync(newEntityCreation())).Entity;
            afterCreation?.Invoke(entity);

            return entity;
        }
    }
}
