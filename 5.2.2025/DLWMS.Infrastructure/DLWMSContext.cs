using DLWMS.Data;
using DLWMS.Data.IspitIB210178;
using Microsoft.EntityFrameworkCore;

using System.Configuration;

namespace DLWMS.Infrastructure
{
    public class DLWMSContext : DbContext
    {
      
        private string konekcijskiString = ConfigurationManager.ConnectionStrings["DLWMSBaza"].ConnectionString;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(konekcijskiString);
        }

        public DbSet<AkademskaGodina> AkademskeGodine { get; set; }
        public DbSet<Drzava> Drzave { get; set; }
        public DbSet<Grad> Gradovi { get; set; }
        public DbSet<Predmet> Predmeti { get; set; }
        public DbSet<Spol> SpoloviIB210178 { get; set; }
        public DbSet<Student> Studenti { get; set; }
        public DbSet<RazmjeneIB210178> RazmjeneIB210178 { get; set; }
        public DbSet<UniverzitetiIB210178> UniverzitetiIB210178 { get; set; }

    }
}
