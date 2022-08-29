using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Carro> Carro{ get; set; }
        public DbSet<Moto> Moto{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("host=localhost; Port=5540; Password=123456; UserId=postgres; Database=postgres");
        }
    }
}
