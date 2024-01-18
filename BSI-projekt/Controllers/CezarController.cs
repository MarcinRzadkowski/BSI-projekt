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

        public IActionResult deszyfr(Cezar model)
        {
            return View(model);
        }

        public IActionResult szyfr(Cezar model)
        {
            return View(model);
        }


            

    }
}
