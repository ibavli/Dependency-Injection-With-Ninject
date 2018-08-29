using DependencyInjectionWithNinject.Dal.Abstract;
using DependencyInjectionWithNinject.Dal.Concrete.Manager;
using DependencyInjectionWithNinject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithNinject.Dal.Concrete
{
    public class EfAdminDal : IAdminDal
    {
        DatabaseContext db = DatabaseContext.CreateDBWithSingleton();

        public void CreateAdmin(Admin admin)
        {
            db.Admin.Add(admin);
            db.SaveChanges();
        }

        public Admin GetAdmin(string Username)
        {
            return db.Admin.Where(a => a.UserName == Username).FirstOrDefault();
        }

    }
}
