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
        public int Electors { get; set; }
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

        public decimal? LabelX { get; set; }
        public decimal? LabelY { get; set; }
        public decimal? TextX { get; set; }
        public decimal? TextY { get; set; }

        public USStatePartyEnum Party { get; set; } = USStatePartyEnum.None;

        public bool HasBullet { get => LabelX > 0; }
    }
}
