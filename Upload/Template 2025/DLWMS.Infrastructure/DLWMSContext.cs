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
        public DbSet<Spol> SpolIB210178 { get; set; }
        public DbSet<StudentiUvjerenjaIB210178> StudentiUvjerenjaIB210178 { get; set; }
        public DbSet<Student> Studenti { get; set; }

    }
}
