using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PsychologyProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyProject.DataAccess.Concrete
{
    public class DataContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SELIM\\MYSQLSERVER; Database=PsikolojiProjesi; Trusted_Connection=True;TrustServerCertificate=True; ");
        }

        public DbSet<Home> homes { get; set; }
        public DbSet<Contact> contacts { get; set; }
        public DbSet<AboutUsItem> aboutUsItems { get; set; }
        public DbSet<Navbar> navbars { get; set; }
        public DbSet<Service> services { get; set; }
        public DbSet<ServiceItem> serviceItem { get; set; }
        public DbSet<Footer> footers { get; set; }
        public DbSet<AboutUs> aboutUs { get; set; }
        public DbSet<SideBarCategory> sideBarCategories { get; set; }
        public DbSet<SideBar> sideBars { get; set; }
        public DbSet<Slider> sliders { get; set; }
        public DbSet<Brief> briefs { get; set; }
    }
}
