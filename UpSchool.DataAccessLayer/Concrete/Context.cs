using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpSchool.EntityLayer.Concrete;

namespace UpSchool.DataAccessLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-H7B28ES;database=CoreDBOtel; integrated security=true");

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<EntityLayer.Concrete.Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<EntityLayer.Concrete.Room> Rooms { get; set; }
        public DbSet<EntityLayer.Concrete.Emploee> Emploees { get; set; }

    }
}
