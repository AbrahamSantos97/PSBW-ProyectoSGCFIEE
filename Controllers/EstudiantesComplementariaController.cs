using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using System.Diagnostics;

namespace SGCFIEE.Controllers
{
    public class EstudiantesComplementariaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CrearPrograma()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPrograma(ProgramaEducativo programa)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.ProgramaEducativo.Add(programa);
                context.SaveChanges();
                TempData["Mensaje"] = "Programa agregado correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarProgramas() {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var lista = context.ProgramaEducativo.ToList();
                return View(lista);
            }

        }
        public IActionResult DetallesPrograma(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var lista = context.ProgramaEducativo.Where(s => s.IdProgramaEducativo == id).Single();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarPrograma(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.ProgramaEducativo.Where(o => o.IdProgramaEducativo == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarPrograma(ProgramaEducativo programa)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.ProgramaEducativo.Update(programa);
                context.SaveChanges();
                TempData["mensaje"] = "Datos actualizados correctamente";
                return RedirectToAction("MostrarProgramas");
            }
        }
        [HttpGet]
        public IActionResult CrearRubro()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearRubro(TbRubrosexamenes rubro)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.TbRubrosexamenes.Add(rubro);
                context.SaveChanges();
                TempData["Mensaje"] = "Rubro guardado correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarRubro()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var lista = context.TbRubrosexamenes.ToList();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarRubro(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.TbRubrosexamenes.Where(o => o.IdTbRubrosExamenes == id).First();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarRubro(TbRubrosexamenes rubro)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TbRubrosexamenes.Update(rubro);
                context.SaveChanges();
                TempData["mensaje"] = "datos actualziados correctamente";
                return RedirectToAction("MostrarRubro");
            }
        }
        [HttpGet]
        public IActionResult Eliminar(int id)
        {
            return Content(id.ToString());
        }
        [HttpGet]
        public IActionResult CrearSalon()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearSalon(TbSalones salon)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.TbSalones.Add(salon);
                context.SaveChanges();
                TempData["Mensaje"] = "Salon agregado correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarSalon()
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var lista = context.TbSalones.ToList();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarSalon(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.TbSalones.Where(o => o.IdTbSalones == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarSalon(TbSalones salon)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TbSalones.Update(salon);
                context.SaveChanges();
                TempData["mensaje"] = "datos actualziados correctamente";
                return RedirectToAction("MostrarSalon");
            }
        }
        [HttpGet]
        public IActionResult CrearArea()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearArea(AreaExperienciaEducativa area)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.AreaExperienciaEducativa.Add(area);
                context.SaveChanges();
                TempData["mensaje"] = "El area se guardo correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarArea()
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var lista = context.AreaExperienciaEducativa.ToList();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarArea(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.AreaExperienciaEducativa.Where(o => o.IdAreaExperienciaEducativa == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarArea(AreaExperienciaEducativa area)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.AreaExperienciaEducativa.Update(area);
                context.SaveChanges();
                TempData["mensaje"] = "datos acrualizados correctamente";
                return RedirectToAction("MosrarArea");
            }
        }
        [HttpGet]
        public IActionResult CrearExperiencia()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.AreaExperienciaEducativa.ToList();
                ViewData["area"] = x;
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearExperiencia(ExperienciaEducativa expe)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.ExperienciaEducativa.Add(expe);
                context.SaveChanges();
                TempData["Mensaje"] = "Experiencia agregada correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarExperiencia()
        {
            List<TablaExperiencia> list = new List<TablaExperiencia>();
            using (sgcfieeContext context = new sgcfieeContext()) {
                list = (from a in context.AreaExperienciaEducativa
                        join
                        e in context.ExperienciaEducativa on a.IdAreaExperienciaEducativa equals e.IdArea
                        select
                        new TablaExperiencia
                        {
                            IdExperienciaEducativa = e.IdExperienciaEducativa,
                            Nombre = e.Nombre,
                            Creditos = e.Creditos,
                            Horas = e.Horas,
                            Nombrearea = a.Nombre
                        }).ToList();
                return View(list);
            }
        }
        [HttpGet]
        public IActionResult EditarExperiencia(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.AreaExperienciaEducativa.ToList();
                ViewData["areae"] = x;
                var objeto = context.ExperienciaEducativa.Where(o => o.IdExperienciaEducativa == id).Single();                
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarExperiencia(ExperienciaEducativa expe)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {

                context.ExperienciaEducativa.Update(expe);
                context.SaveChanges();
                TempData["Mensjae"] = "datos actualziados correctamente";
                return RedirectToAction("MostrarExperiencia");
            }
        }
        [HttpGet]
        public IActionResult CrearMovilidad()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearMovilidad(CtMovilidades movi)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.CtMovilidades.Add(movi);
                context.SaveChanges();
                TempData["Mensaje"] = "Movildiad guardada correctamente"
;                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarMovilidad() 
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var lista = context.CtMovilidades.ToList();
                return View(lista);
            }
        }
        public IActionResult DetallesMovilidad(int id) 
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                var detalle = context.CtMovilidades.Where(s => s.IdCtMovilidades == id).Single();
                return View(detalle);
            }
        }
        [HttpGet]
        public IActionResult EditarMovilidad(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.CtMovilidades.Where(o => o.IdCtMovilidades == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarMovilidad(CtMovilidades movi)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.CtMovilidades.Update(movi);
                context.SaveChanges();
                TempData["Mensaje"] = "Datos actualizados correctamente";
                return RedirectToAction("MostrarMovilidad");
            }
        }
        [HttpGet]
        public IActionResult CrearTipo()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearTipo(CtTipoCalificacion tip)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.CtTipoCalificacion.Add(tip);
                context.SaveChanges();
                TempData["Mensaje"] = "El tipo se ha guardado correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarTipo()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var lista = context.CtTipoCalificacion.ToList();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarTipo(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.CtTipoCalificacion.Where(o => o.IdCtTipoCalificacion == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarTipo(CtTipoCalificacion cali)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.CtTipoCalificacion.Update(cali);
                context.SaveChanges();
                TempData["Menssaje"] = "Datos actualizados correctamente";
                return RedirectToAction("MostrarTipo");
            }
        }
        [HttpGet]
        public IActionResult CrearTipoe()
        {
                return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearTipoe(TipoEventos tipoe)
        {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.TipoEventos.Add(tipoe);
                context.SaveChanges();
                TempData["Mensaje"] = "El tipo de evento ha sido guardado";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarTipoe()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var lista = context.TipoEventos.ToList();
                return View(lista);
            }
        }
        [HttpGet]
        public IActionResult EditarTipoe(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var objeto = context.TipoEventos.Where(o => o.IdEventos == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarTipoe(TipoEventos tipoe)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoEventos.Update(tipoe);
                context.SaveChanges();
                TempData["Mensaje"] = "Datos actualziados correctamente";
                return RedirectToAction("MostrarTipoe");
            }
        }
        [HttpGet]
        public IActionResult CrearEvento()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.TipoEventos.ToList();
                ViewData["tipo"] = x;
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearEvento(TbEventos evento)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.TbEventos.Add(evento);
                context.SaveChanges();
                TempData["Mensaje"] = "Evento guardado correctamente";
                return RedirectToAction("Index");
            }
        }
        public IActionResult MostrarEvento()
        {
            List<TablaEvento> list = new List<TablaEvento>();
            using (sgcfieeContext context = new sgcfieeContext())
            {
                list = (from t in context.TipoEventos
                        join
                        e in context.TbEventos on t.IdEventos equals e.IdEventos
                        select
                        new TablaEvento
                        {
                            IdEventos = e.IdEventos,
                            Nombre = e.Nombre,
                            NombreEvento = t.Nombre
                        }).ToList();
                return View(list);
            }
        }
        [HttpGet]
        public IActionResult EditarEvento(int id)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.TipoEventos.ToList();
                ViewData["evento"] = x;
                var objeto = context.TbEventos.Where(o => o.IdEventos == id).Single();
                return View(objeto);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditarEvento(TbEventos eve)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TbEventos.Update(eve);
                context.SaveChanges();
                TempData["mensaje"] = "Datos actualizados correctamente";
                return RedirectToAction("MostrarEvento");
            }
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}