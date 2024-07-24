using USElections.Data.Models.FootballModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Data
{
    public partial class FootballdBContext : DbContext
    {
        public FootballdBContext(DbContextOptions<FootballdBContext> options)
            : base(options)
        {

        }

        public virtual DbSet<Team> Team {  get; set; }
        public virtual DbSet<TeamDetails> TeamDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {



            optionsBuilder.UseSqlServer(@"Server=tcp:clt-metro-footballdb.database.windows.net,1433;Initial Catalog=FootballdB_v2;Persist Security Info=False;User ID=cltMetroFootball;Password=cltMetro123*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=3000;");
            base.OnConfiguring(optionsBuilder);

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
   
}
