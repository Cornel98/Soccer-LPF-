
namespace PROIECTDaw.Models.DTOs
{
    // DTO pentru a transfera datele echipei
    public class EchipeDTO
    {
        public int IdEchipa { get; set; }
        public string? Nume { get; set; }
        public string? Emblema { get; set; }
        public decimal ValoareEchipa { get; set; }
        public DateTime DataInfiintare { get; set; }

        public List<JucatoriDTO> ? Jucatori { get; set; }
    }
}

