using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace USElections.Data.Models;

public class StateBullets
{
    [Key]
    public int ID { get; set; }
    
    public int GID { get; set; }
    [ForeignKey("GID")]
    public USState? USState { get; set; }

    public decimal LabelX { get; set; }
    public decimal LabelY { get; set; }
    public decimal TextX { get; set; }
    public decimal TextY { get; set; }
    public string Name { get; set; }
}
