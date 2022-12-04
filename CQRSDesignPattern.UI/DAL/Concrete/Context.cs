using CQRSDesignPattern.UI.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRSDesignPattern.UI.DAL.Concrete
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.; initial catalog=CQRSDb; integrated security=true");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
