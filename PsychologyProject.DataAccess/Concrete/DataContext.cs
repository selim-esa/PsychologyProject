using Microsoft.EntityFrameworkCore;
using PsychologyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.DataAccess.Concrete
{
    public class DataContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SELIM\\MYSQLSERVER; Database=PsikolojiProjesi; Trusted_Connection=True;TrustServerCertificate=True; ");
        }
        public DbSet<Home> homes { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<Navbar> navbars { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<Footer> footers { get; set; }
        public DbSet<AboutUs> aboutUs { get; set; }
    }
}
