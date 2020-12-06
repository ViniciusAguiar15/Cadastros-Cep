using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cadastro_de_CEPs.Models;

namespace Cadastro_de_CEPs.Controllers {
    public class HomeController : Controller {

        public IActionResult Index() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
