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
        public ActionResult Index()
        {
            List<CtMovilidades> movilidades = new List<CtMovilidades>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                movilidades = context.CtMovilidades.ToList<CtMovilidades>();
            }
            return View(movilidades);
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