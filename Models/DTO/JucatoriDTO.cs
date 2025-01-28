namespace PROIECTDaw.Models.DTOs;
public class JucatoriDTO
{
    public int IdJucator { get; set; }
    public string? Nume { get; set; }
    public string ?Prenume { get; set; }
    public int IdEchipa { get; set; }
    public decimal Salariu { get; set; }
    public int IdPozitie { get; set; }
    public DateTime DataNasterii { get; set; }
    public string ?PozaProfil { get; set; }
    public string? Pozitie { get; set; }
}
