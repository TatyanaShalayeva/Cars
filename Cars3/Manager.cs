using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars.DataModel;
using System.Data.Entity;

namespace Cars3
{
    class Manager
    {

        public static void Insert<TEntity>(TEntity entity) where TEntity : class
        {
            using (CarsContext context = new CarsContext())
            {
                DbSet<TEntity> dbset = context.Set<TEntity>();
                dbset.Add(entity);
                context.SaveChanges();
            }
        }
        public static void Insert<TEntity>(List<TEntity> entity) where TEntity : class
        {
            using (CarsContext context = new CarsContext())
            {
                DbSet<TEntity> dbset = context.Set<TEntity>();
                dbset.AddRange(entity);
                context.SaveChanges();
            }
        }

        public static void Update<TEntity>(TEntity entity) where TEntity : class
        {
            using (CarsContext context = new CarsContext())
            {
                DbSet<TEntity> dbset = context.Set<TEntity>();
                context.Entry(entity).State = EntityState.Modified;
                context.Database.Log = Console.WriteLine;
                context.SaveChanges();

            }
        }

        public static TEntity Find<TEntity>(int id) where TEntity : class
        {
            using (CarsContext context = new CarsContext())
            {
                
                DbSet<TEntity> dbset = context.Set<TEntity>();
                TEntity tmp = dbset.Find(id);
                //context.SaveChanges();
                return tmp;

            }
        }

    }
}
