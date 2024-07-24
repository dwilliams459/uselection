using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Data.Models
{
    public class USState
    {
        public int GID { get; set; }
        public string Name { get; set; }
        public int? Electors { get; set; }
        public int? RegionId { get; set; }
        public int? RegionName { get; set; }
        public int StateId { get; set; }
        public string Path { get; set; }
        public string PathType { get; set; }
        public string PathSuffix { get; set; }
        public bool? IsTerritory { get; set; }
        public decimal? TransformX { get; set; }
        public decimal? TransformY { get; set; }
    }
}
