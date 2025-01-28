using Microsoft.AspNetCore.Mvc;
using PROIECTDaw.DataContext;
using PROIECTDaw.Models.DTOs;
using System.Linq;

public class HomeController : Controller
{
    private readonly TeamAppDb _context; // Contextul bazei de date

    // Constructorul primește contextul bazei de date prin injecție de dependență
    public HomeController(TeamAppDb context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        // Preia echipele din baza de date și le mapează în DTO-uri
        var echipe = _context.Echipe // Asumăm că există o proprietate DbSet<Echipa> în context
            .Select(e => new EchipeDTO
            {
                Nume = e.Nume,
                Emblema = e.Emblema,
                ValoareEchipa = e.ValoareEchipa,
                DataInfiintare = e.DataInfiintare
            })
            .ToList();

        // Verifică dacă există echipe
        if (echipe == null || !echipe.Any())
        {
            ViewBag.Message = "Nu au fost găsite echipe.";
        }

        return View(echipe);
    }
}
