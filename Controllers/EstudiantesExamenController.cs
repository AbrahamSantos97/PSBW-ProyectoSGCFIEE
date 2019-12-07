using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;

namespace SGCFIEE.Controllers
{
    public class EstudiantesExamenController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["tipo"] = (int)HttpContext.Session.GetInt32("TipoUsuario");
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.TbRubrosexamenes.ToList();
                ViewData["rubros"] = x;
                return View();
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(List<TbExamenalumno> examen)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                foreach (var item in examen)
                {
                    context.TbExamenalumno.Add(item);
                    context.SaveChanges();
                    TempData["mensaje"] = "Dato guardado";
                }
                return RedirectToAction("/Home/Default");
            }
        }
    }
}