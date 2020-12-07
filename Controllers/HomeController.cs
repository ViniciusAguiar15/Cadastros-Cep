using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Cadastro_de_CEPs.Models;
using Cadastro_de_CEPs.Services.Interfaces;
using System;

namespace Cadastro_de_CEPs.Controllers {
    public class HomeController : Controller {

        private readonly IEnderecoService _enderecoService;

        public HomeController(IEnderecoService enderecoService) {
            _enderecoService = enderecoService;
        }

        public IActionResult Index() {
            ViewBag.Enderecos = _enderecoService.Listar();
            return View();
        }

        [HttpPost]
        public ActionResult Create([FromForm] Endereco endereco) {
            if (ModelState.IsValid) {
                try {
                    _enderecoService.Cadastrar(endereco);
                    return RedirectToAction(nameof(Index));
                } catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
