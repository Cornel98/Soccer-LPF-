using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PROIECTDaw.DataContext;

namespace PROIECTDaw.Controllers
{
    public class TestController : Controller
    {
        private readonly TeamAppDb _context;

        public TestController(TeamAppDb context)
        {
            _context = context;
        }

        public IActionResult TestConnection()
        {
            try
            {
                // Verifică dacă se poate face o interogare simplă
                if (_context.Database.CanConnect())
                {
                    return Ok("Conexiune reușită la baza de date.");
                }
                else
                {
                    return BadRequest("Nu se poate stabili conexiunea cu baza de date.");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Eroare la conexiune: {ex.Message}");
            }
        }
    }
}
