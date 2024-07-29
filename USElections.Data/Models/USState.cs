using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Data.Models
{
    public class USState
    {
        [Key]
        public int GID { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Electors { get; set; }

        public decimal? BulletX { get; set; }
        public decimal? BulletY { get; set; }
        public decimal? LabelX { get; set; }
        public decimal? LabelY { get; set; }

        public string Fill { get; set; } = string.Empty;
        public string Stroke { get; set; } = string.Empty;
        public string Path { get; set; } = string.Empty;
        public string Class { get; set; } = string.Empty;
        public decimal? Opacity { get; set; }
        public decimal? StrokeOpacity { get; set; }
        public decimal? StrokeWidth { get; set; }
        public string StrokeLinejoin { get; set; } = string.Empty;
        public string Transform { get; set; } = string.Empty;
        public string Style { get; set; } = string.Empty;
        public decimal? FillOpacity { get; set; }

        public StateBullets? StateBullets { get; set; }
    }
}
