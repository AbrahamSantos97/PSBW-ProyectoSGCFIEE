using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;

namespace SGCFIEE.Controllers
{
    public class EstudiantesMovilidadController : Controller
    {
        // GET: EstudiantesMovilidad
        [Authorize]
        public ActionResult Index(CtMovilidades movi)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                var movilidades = context.CtMovilidades.Where(s => s.TipoMovilidades.Equals(movi.TipoMovilidades)).ToList();
                ViewData["Movilidades"] = movilidades;
            }
            return View();
        }
        [Authorize]
        public IActionResult EleccionMovilidades()
        {
            return View();
        }
        

        // GET: EstudiantesMovilidad/Edit/5
        [Authorize]
        public IActionResult Editar(int id)
        {
            CtMovilidades datosMovi;
            using(sgcfieeContext context = new sgcfieeContext())
            {
                datosMovi = context.CtMovilidades.Where(d => d.IdCtMovilidades == id).Single();
            }
            return View(datosMovi);
        }

        public IActionResult GuardarEdicion(CtMovilidades movilidades)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.CtMovilidades.Update(movilidades);
                context.SaveChanges();
                TempData["Mensaje"] = "La informacion se ha guardado correctamente";
            }
            return RedirectToAction("Index");
        }

        // GET: EstudiantesMovilidad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

    }
}