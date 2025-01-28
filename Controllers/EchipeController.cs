using Microsoft.AspNetCore.Mvc;
using PROIECTDaw.DataContext; // Asigură-te că ai contextul bazei de date aici
using PROIECTDaw.Models.DTOs; // DTO-ul echipelor
using System.Linq; // Pentru LINQ

namespace PROIECTDaw.Controllers
{
    public class EchipeController : Controller
    {
        private readonly TeamAppDb _context; // Contextul bazei de date

        // Constructorul primește contextul bazei de date prin injecție de dependență
        public EchipeController(TeamAppDb context)
        {
            _context = context;
        }

        // Metodă pentru a obține echipele din baza de date și a le trimite către view
        public IActionResult Index()
        {
            // Extrage toate ID-urile echipelor din baza de date
            var echipeIduri = _context.Echipe
                                      .Select(e => e.IdEchipa)  // Selectează doar ID-urile echipelor
                                      .ToList();  // Creează o listă cu ID-urile

            // Extrage echipele din baza de date care au unul din ID-urile din lista echipeIduri
            var echipe = _context.Echipe
                .Where(e => echipeIduri.Contains(e.IdEchipa)) // Filtrăm echipele doar pe baza acestor ID-uri
                .Select(e => new EchipeDTO
                {
                    IdEchipa = e.IdEchipa, // Nu uita să adaugi și IdEchipa pentru a-l folosi în view
                    Nume = e.Nume,
                    Emblema = e.Emblema,
                    ValoareEchipa = e.ValoareEchipa,
                    DataInfiintare = e.DataInfiintare
                })
                .ToList();

            // Verifică dacă nu sunt echipe disponibile
            if (echipe == null || !echipe.Any())
            {
                ViewBag.Message = "Nu sunt echipe disponibile.";
            }

            // Returnează echipele către view
            return View("Echipe", echipe);
        }
    }
}
