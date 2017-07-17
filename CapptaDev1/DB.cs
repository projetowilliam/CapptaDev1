using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using CapptaDev1.Properties;
namespace CapptaDev1
{
    class DB: DbContext
    {
       public DbSet<CarroPopular> CarroPopular { get; set; }
       public DbSet<Pessoa> Pessoa { get; set; }

    }
}
