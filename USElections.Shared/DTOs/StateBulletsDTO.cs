using System.ComponentModel.DataAnnotations;

namespace USElections.Shared.DTOs;

public class StateBulletsDTO
{
    [Key]
    public int ID { get; set; }
    public int GID { get; set; }
    public decimal LabelX { get; set; }
    public decimal LabelY { get; set; }
    public decimal TextX { get; set; }
    public decimal TextY { get; set; }
    public string Name { get; set; }
}
