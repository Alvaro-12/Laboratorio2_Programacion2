using Laboratorio2.Dominio;
using Laboratorio2.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laboratorio2.Controllers
{
    public class PersonaController1 : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IPersona ipersona;

        public PersonaController1(ILogger<HomeController> logger, IPersona ipersona)
        {
            this.ipersona = ipersona;
            _logger = logger;
        }

        public IActionResult Index()
        {
            var Lista = ipersona.ListarPersonas();

            return Json(new { data = Lista});
        }

        public IActionResult Guardar()
        {


            return View();
        }

    }
}
