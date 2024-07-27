using Microsoft.EntityFrameworkCore;

namespace MicroYazilim.Models.Data
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=DESKTOP-V7NEGGO\\SQLEXPRESS;database=MicroYazilim;integrated security=true;" +
                "TrustServercertificate=True;"
                );
        }
        public DbSet<Calisanlar> Calisanlar { get; set; }
        public DbSet<Hizmetler> Hizmetler { get; set; }
        public DbSet<Iletisim> Iletisim { get; set; }
        public DbSet<Referanslar> Referanslar { get; set; }
        public DbSet<Teklif> Teklifs { get; set; }
    }
}
