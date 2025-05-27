using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Laba10.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public virtual DbSet<Abonent> Abonents { get; set; }

        public virtual DbSet<Schetchik> Schetchiks { get; set; }

        public virtual DbSet<Pokazanie> Pokazanies { get; set; }
    }
}
