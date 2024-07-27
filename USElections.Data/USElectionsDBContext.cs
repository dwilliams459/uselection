using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USElections.Data.Models;

namespace USElections.Data
{
    public class USElectionsDBContext : DbContext
    {
        public USElectionsDBContext(DbContextOptions<USElectionsDBContext> options) : base (options)
        {
            
        }

        public DbSet<USState> USStates { get; set; }
        public DbSet<StateBullets> StateBullets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<USState>(entity =>
            {
                entity.HasKey(e => e.GID);
            });

            modelBuilder.Entity<StateBullets>(entity =>
            {
                entity.HasKey(e => e.ID);
            });
        }

    }
}
