using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Concrete.Context
{
    public class PharmacyContext :IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-GQ26LQR\SQLEXPRESS; initial catalog= PharmacyDb; integrated security = true");
        }

        public DbSet<Medicine>? Medicines { get; set; }
        public DbSet<Order>? Orders { get; set; }
        public DbSet<Stock>? Stocks  { get; set; }
     
    }
}
