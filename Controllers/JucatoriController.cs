using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROIECTDaw.DataContext;
using PROIECTDaw.Models.DTOs;
using System.Linq;

namespace PROIECTDaw.Controllers
{
    public class JucatoriController : Controller
    {
        private readonly TeamAppDb _context;

        // Constructorul primește contextul bazei de date prin injecție de dependență
        public JucatoriController(TeamAppDb context)
        {
            _context = context;
        }

        public IActionResult Index(int idEchipa)
        {
            // Preia echipa cu idEchipa și jucătorii acesteia
            var echipa = _context.Echipe
                .Where(e => e.IdEchipa == idEchipa)
                .Select(e => new EchipeDTO
                {
                    IdEchipa = e.IdEchipa,
                    Nume = e.Nume,
                    Emblema = e.Emblema,
                    ValoareEchipa = e.ValoareEchipa,
                    DataInfiintare = e.DataInfiintare
                })
                .FirstOrDefault();

            if (echipa == null)
            {
                // Dacă nu găsește echipa, afișează un mesaj
                ViewBag.Message = "Echipa nu a fost găsită.";
                return View("Jucatori", null);
            }

            // Preia jucătorii echipei selectate
            var jucatori = _context.Jucatori
    .Include(j => j.Pozitie) // Include poziția
    .Where(j => j.IdEchipa == idEchipa)
    .Select(j => new JucatoriDTO
    {
        IdJucator = j.IdJucator,
        Nume = j.Nume,
        Prenume = j.Prenume,
        DataNasterii = j.DataNasterii,
        Salariu = j.Salariu,
        PozaProfil = j.PozaProfil,
        Pozitie = j.Pozitie.Denumire 
    })
    .ToList();


            // Creează modelul pentru vizualizare
            var echipaJucatoriViewModel = new EchipaJucatoriViewModel
            {
                Echipa = echipa,
                Jucatori = jucatori
            };

            return View("Jucatori", new List<EchipaJucatoriViewModel> { echipaJucatoriViewModel });
        }



    }
}
