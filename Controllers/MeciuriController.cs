using Microsoft.AspNetCore.Mvc;

namespace PROIECTDaw.Controllers
{
    public class MeciuriController : Controller
    {
        // Acțiunea care va deschide pagina Meciuri
        public IActionResult Index()
        {
            return View("Meciuri");  // Aceasta va deschide Meciuri.cshtml
        }
    }
}
