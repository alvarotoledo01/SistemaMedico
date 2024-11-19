using Microsoft.AspNetCore.Mvc;
using SistemaMedico.Models; 
using System.Linq;
using System.Collections.Generic;
using SistemaMedico.Context;



    namespace SistemaMedico.Controllers
    {
        public class MedicoController : Controller
        {
        public IActionResult BuscarPacientes()
        {
            return View("~/Views/Medico/BuscarPacientes.cshtml");

        }
        public IActionResult Dashboard()
            {
            return View("~/Views/Medico/Dashboard.cshtml");

        }
    }
    }



