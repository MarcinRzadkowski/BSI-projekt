using Microsoft.AspNetCore.Mvc;
using BSI_projekt.Models;

namespace BSI_projekt.Controllers
{
    public class CezarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Form()
        {
            return View();
        }
    }
}
