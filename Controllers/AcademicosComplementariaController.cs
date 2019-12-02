using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SGCFIEE.Controllers
{
    public class AcademicosComplementariaController : Controller
    {
        public IActionResult VistaOpcionesCatalogos()
        {
            return View();
        }
    }
}