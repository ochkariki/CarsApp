using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars.Data
{
    class Context : DbContext
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Car> C { get; set; }

        public Context() : base("localsql")
        {
        }

    }
}
