using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using WebApp.Models;

namespace WebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        /*
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
               
        }

        */

        public DbSet<Sighting> Sightings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("Server=16.170.225.216;Database=MySQLHessdalen;Uid=ClientDBAccess;Pwd=ClientDBAccessPass;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Sighting>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Description).IsRequired();
            });
        }
    }
}
