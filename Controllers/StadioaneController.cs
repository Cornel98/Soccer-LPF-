using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PROIECTDaw.DataContext;  // Namespace pentru contextul bazei de date
using System.Linq;
using PROIECTDaw.Models.DTO;  // Folosim corect DTO-ul din namespace-ul corespunzător
using static PROIECTDaw.Models.DTO.StadioaneDTO_cs;

namespace PROIECTDaw.Controllers
{
    public class StadioaneController : Controller
    {
        private readonly TeamAppDb _context; // Contextul bazei de date

        // Constructorul primește contextul bazei de date prin injecție de dependență
        public StadioaneController(TeamAppDb context)
        {
            _context = context;
        }

        // GET: Stadioane
        public IActionResult Index()
        {
            // Obține lista de stadioane din baza de date
            var stadioane = _context.Stadioane
                .Join(_context.Locatii, stadion => stadion.IdLocatie, locatie => locatie.IdLocatie, (stadion, locatie) => new { stadion, locatie })
                .Join(_context.Tari, combined => combined.locatie.IdTara, tara => tara.IdTara, (combined, tara) => new StadionDTO
                {
                    IdStadion = combined.stadion.IdStadion,
                    IdLocatie = combined.stadion.IdLocatie,
                    Nume = combined.stadion.Nume,
                    Capacitate = combined.stadion.Capacitate,
                    Oras = combined.locatie.Oras,
                    Imagine = combined.stadion.Imagine,  // Adaugă imaginea
                    DenumireTara = tara.Denumire
                }).ToList();

            if (stadioane == null || !stadioane.Any())
            {
                return NotFound(); // Poți personaliza pentru a afișa un mesaj de eroare în view
            }

            return View("Stadioane", stadioane);  // Trimite lista de stadioane către view
        }
    }
}
