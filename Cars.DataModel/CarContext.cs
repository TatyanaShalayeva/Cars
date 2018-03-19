using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Cars.DomainClasses;

namespace Cars.DataModel
{
    public class CarsContext : DbContext
    {
        public CarsContext() : base("DbConnection") { }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Engine> Engins { get; set; }
    }
}
