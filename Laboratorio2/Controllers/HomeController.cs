using Laboratorio2.Dominio;
using Laboratorio2.Models;
using Laboratorio2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPersona ipersona;
        public HomeController(ILogger<HomeController> logger, IPersona ipersona)
        {
            this.ipersona = ipersona;
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            var Lista = ipersona.ListarPersonas();

            return Json(new { data = Lista });

        }

        public IActionResult Guardar()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Registro(persona personaModel)
        {
            if (ModelState.IsValid)
            {
                persona per = new persona();
                per.NombrePersona = personaModel.NombrePersona;
                per.EdadPersona = personaModel.EdadPersona;
                per.DescripcionPersona = personaModel.DescripcionPersona;

                ipersona.Insertar(per);
                return Redirect("/Home/Index");
            }



            else
            {
                return View("Guardar", personaModel);
            }




            
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
