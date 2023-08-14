using Microsoft.EntityFrameworkCore;

namespace Anizyl.Entities
{
   public class AnizylDbContext : DbContext
   {
      private string _conectionString = "Server=(localdb)\\mssqllocaldb;Database=AnizylDb;Trusted_Connection=True;";
     public required DbSet<Animal> Animals { get; set; }
      public required DbSet<AnimalType> AnimalsType { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Animal>()
         .Property(a => a.Name)
         .IsRequired()
         .HasMaxLength(25);
      }

      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseSqlServer(_conectionString);
         
      }


   }
}