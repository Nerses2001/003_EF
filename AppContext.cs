using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace _003_EF
{
    internal class AppContext:DbContext
    {
        public DbSet<Phone> Phones { get; set; }   
        public AppContext()
        {
            Database.EnsureDeleted();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new SqlConnectionStringBuilder
            {
                DataSource = ".",
                InitialCatalog = "003_ED",
                IntegratedSecurity = true,
                TrustServerCertificate = true,
            };

            optionsBuilder.UseSqlServer(builder.ConnectionString); //("server=.;database=TestDB;Trusted_Connection=True;"); 
        }

        /*  protected override void OnModelCreating(ModelBuilder modelBuilder)
          {
              modelBuilder.Ignore<Company>();
          }
        */
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Planshet>();
            modelBuilder.Ignore<Company>();
        }

    }
}
