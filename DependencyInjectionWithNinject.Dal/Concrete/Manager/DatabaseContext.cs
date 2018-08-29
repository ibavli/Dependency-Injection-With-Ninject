using DependencyInjectionWithNinject.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithNinject.Dal.Concrete.Manager
{
    public class DatabaseContext : DbContext
    {

        //Singleton Design Pattern
        private static DatabaseContext databaseContext;
        static object _lock = new object();
        private DatabaseContext()
        {

        }
        public static DatabaseContext CreateDBWithSingleton()
        {
            lock (_lock)
            {
                if (databaseContext == null)
                {
                    databaseContext = new DatabaseContext();
                }
            }
            return databaseContext;
        }

        public DbSet<Admin> Admin { get; set; }
    }
}
