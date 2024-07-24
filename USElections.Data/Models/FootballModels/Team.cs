using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USElections.Data.Models.FootballModels
{
    [Table("FootballdB_Team", Schema = "cltFB")]

    public partial class Team
    {
        [Key]
        public int RowId { get; set; }
        public string TeamName { get; set; }
    }
}
