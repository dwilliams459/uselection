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

    }
}
