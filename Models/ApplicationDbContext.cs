using System.Data.Entity;
namespace Ski_Rental.Models
{
    

    public class ApplicationDbContext : DbContext
    {
        public DbSet<Narty> Narty { get; set; }
        public DbSet<ButyNarciarskie> ButyNarciarskie { get; set; }
        public DbSet<Rezerwacja> Rezerwacje { get; set; }

        public ApplicationDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Narty>().ToTable("Narty");
            modelBuilder.Entity<ButyNarciarskie>().ToTable("ButyNarciarskie");
            modelBuilder.Entity<Rezerwacja>().ToTable("Rezerwacje");
        }
    }
}
