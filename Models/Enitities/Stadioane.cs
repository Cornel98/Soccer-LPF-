using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROIECTDaw.Models.Enitities;

[Table("Stadioane")]
public class Stadioane
{
    [Key]
    public required int IdStadion { get; set; }
    public required int IdLocatie { get; set; }
    public required string Nume { get; set; }
    public required int Capacitate { get; set; }
    public required string Imagine { get; set; }
    
    [ForeignKey("IdLocatie")]
    public Locatii? Locatie { get; set; }
}