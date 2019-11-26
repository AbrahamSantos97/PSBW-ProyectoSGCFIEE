using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;

namespace SGCFIEE.Controllers
{
    public class EstudiantesMovilidadController : Controller
    {
        // GET: EstudiantesMovilidad
        
        public ActionResult Index()
        {
            List<CtMovilidades> movilidades = new List<CtMovilidades>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                movilidades = context.CtMovilidades.ToList<CtMovilidades>();
            }
            return View(movilidades);
        }
        // GET: EstudiantesMovilidad/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudiantesMovilidad/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesMovilidad/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudiantesMovilidad/Edit/5
        //[ValidateAntiForgeryToken]
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

        // POST: EstudiantesMovilidad/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudiantesMovilidad/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudiantesMovilidad/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}