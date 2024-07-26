using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Shared.DTOs
{
    public class USStateDTO
    {
        [Key]
        public int GID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int? Electors { get; set; }
        public int? RegionId { get; set; }
        public int? RegionName { get; set; }
        public int StateId { get; set; }
        public string Path { get; set; } = string.Empty ;
        public string PathType { get; set; } = string.Empty;
        public string PathSuffix { get; set; } = string.Empty;
        public bool? IsTerritory { get; set; }
        public decimal? TransformX { get; set; } = 0;
        public decimal? TransformY { get; set; } = 0;
    }
}
