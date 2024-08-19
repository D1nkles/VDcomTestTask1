using Microsoft.EntityFrameworkCore;
using VDcomTestTask1.Entities;

namespace VDcomTestTask1
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<IndividualEntity> Individuals { get; set; }
        public DbSet<LegalEntity> Legals { get; set; }
        public DbSet<ContractEntity> Contracts { get; set; }

        public ApplicationContext() 
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ILIA\SQLEXPRESS;Database=VDComTask1DB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
