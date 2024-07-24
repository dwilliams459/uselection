using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Data
{
    public class FootballdBContextFactory : IDesignTimeDbContextFactory<FootballdBContext>
    {
        public FootballdBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<FootballdBContext>();
            optionsBuilder.UseSqlServer("Server=tcp:clt-metro-footballdb.database.windows.net,1433;Initial Catalog=FootballdB_v2;Persist Security Info=False;User ID=cltMetroFootball;Password=cltMetro123*;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            return new FootballdBContext(optionsBuilder.Options);
        }
    }
}
