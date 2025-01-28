using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROIECTDaw.Models.Enitities;

[Table("Campionate")]
public class Campionate
{
    [Key] 
    public int IdCampionat { get; set; }
    public required string Denumire { get; set; }
    
}