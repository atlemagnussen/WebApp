using Microsoft.EntityFrameworkCore;
using MySql.EntityFrameworkCore.Extensions;
using WebApp.Models;
using System.Diagnostics;

namespace WebApp.Data
{
    public class ApplicationDBContext : DbContext
    {
        
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) {}

        public DbSet<Sighting> Sightings { get; set; }

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
