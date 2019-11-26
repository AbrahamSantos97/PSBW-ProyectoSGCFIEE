using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using System.Diagnostics;

namespace SGCFIEE.Controllers
{
    public class EstudiantesEventosController : Controller
    {
        public IActionResult Index()
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.TipoEventos.ToList();
                ViewData["tipos"] = x;
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult ListaEventos(int idTipoEvento)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                var eventosEspecificos = context.TbEventos.Where(s => s.RTioEvento.Equals(idTipoEvento)).ToList<TbEventos>();
                ViewData["NomEventos"] = eventosEspecificos;
            }
            return View();
        }
    }
}