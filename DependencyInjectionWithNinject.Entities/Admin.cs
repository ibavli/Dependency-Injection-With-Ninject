using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionWithNinject.Entities
{
    public class Admin
    {
        public Admin()
        {
            AdminId = Guid.NewGuid();
        }

        [Key]
        public Guid AdminId { get; set; }

        public string UserName { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

    }
}
