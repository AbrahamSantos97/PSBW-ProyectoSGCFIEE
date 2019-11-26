using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using System.Diagnostics;

namespace SGCFIEE.Controllers
{
    public class EstudiantesBuzonController : Controller
    {
        public IActionResult Index()
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.CtProblemas.ToList();
                //var y = context.Academicos.ToList();
                ViewData["Problemas"] = x;
                //ViewData["Academicos"] = x;
            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}