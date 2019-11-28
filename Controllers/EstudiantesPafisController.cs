using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;

namespace SGCFIEE.Controllers
{
    public class EstudiantesPafisController : Controller
    {
        [Authorize]
        public IActionResult Index()
        {
            List<TablaPafi> tb_pafi = new List<TablaPafi>();
            List<TablaPafi> correcto = new List<TablaPafi>();
            TablaPafi aux = new TablaPafi();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                tb_pafi = (from d in context.TbPafisAlumno
                           join
                            p in context.PafisAcademicos on d.RInfopafi equals p.IdPafis
                           join
                           a in context.Academicos on p.IdAcademico equals a.IdAcademicos
                           join
                           s in context.TbSalones on p.IdSalon equals s.IdTbSalones
                           select
                           new TablaPafi
                           {
                               idPafi = p.IdPafis,
                               NombrePafi = p.Nombre,
                               Horario = p.Horario,
                               NombreMaestro = a.Nombre,
                               ApePaterno = a.ApellidoPaterno,
                               ApeMaterno = a.ApellidoMaterno,
                               ClvSalon = s.ClaveSalon,
                           }
                          ).ToList();
            }
            if(tb_pafi.Count > 0)
            {
                foreach(TablaPafi tp in tb_pafi)
                {
                    int contador = 0;
                    foreach(TablaPafi dato in tb_pafi)
                    {
                        if(tp.idPafi == dato.idPafi)
                        {
                            contador++;
                        }
                    }
                    tp.TotalAlum = contador;
                }
                int iterator = 0;
                foreach(TablaPafi tb in tb_pafi)
                {
                    if(correcto.Count == 0)
                    {
                        correcto.Add(tb);
                    }
                    else
                    {
                        int bandera = 0;
                        foreach(TablaPafi c in correcto)
                        {
                            if(c.idPafi == tb.idPafi)
                            {
                                bandera = 1;
                            }
                        }
                        if(bandera == 0)
                        {
                            correcto.Add(tb);
                        }
                    }
                }
                foreach(TablaPafi table in correcto)
                {
                    String nom = table.NombreMaestro;
                    nom = nom + " "+table.ApePaterno;
                    nom = nom + " "+table.ApeMaterno;
                    table.NombreMaestro = nom;
                }
            }

            if (correcto.Count > 0)
            {
                return View(correcto);
            }
            else
            {
                return View(tb_pafi);
            }
            
        }
        [Authorize]
        public IActionResult FormEditar(int id)
        {
            PafisAcademicos pafi;
            using(sgcfieeContext context = new sgcfieeContext())
            {
                pafi = context.PafisAcademicos.Where(s => s.IdPafis == id).Single();
                var x = context.TbSalones.ToList();
                var y = context.Academicos.ToList();
                ViewData["salones"] = x;
                ViewData["academicos"] = y;
            }
            return View(pafi);
        }
        [Authorize]
        public IActionResult Editar(PafisAcademicos pafis)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.PafisAcademicos.Update(pafis);
                context.SaveChanges();
                TempData["Mensaje"] = "La informacion se ha guardado correctamente";
            }
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [Authorize]
        public IActionResult SolicitudPafi()
        {
             using(sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.Academicos.ToList();
                var y = context.TbSalones.ToList();
                ViewData["academicos"] = x;
                ViewData["salones"] = y;
            }
            return View();
        }
        [Authorize]
        public IActionResult Crear(PafisAcademicos pafis)
        {
            TbPafisAlumno tbpafi = new TbPafisAlumno();
            tbpafi.RAlumno = (int)HttpContext.Session.GetInt32("IdUsu");
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.PafisAcademicos.Add(pafis);
                context.SaveChanges();
                TempData["Mensaje"] = "Datos registrados";
                var x = context.PafisAcademicos.Count();
                tbpafi.RInfopafi = x;
                context.TbPafisAlumno.Add(tbpafi);
                context.SaveChanges();
                //TempData["Mensaje"] = "Datos registrados";
            }
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult Inscribir(int id)
        {
            TbPafisAlumno pafis = null;
            TbPafisAlumno nuevo = new TbPafisAlumno();
            int alum = (int)HttpContext.Session.GetInt32("IdUsu");
            using(sgcfieeContext context = new sgcfieeContext())
            {
                pafis = context.TbPafisAlumno.Where(a => a.RAlumno == alum && a.RInfopafi == id).FirstOrDefault();
                if(pafis == null)
                {
                    nuevo.RAlumno = alum;
                    nuevo.RInfopafi = id;
                    context.TbPafisAlumno.Add(nuevo);
                    context.SaveChanges();
                    TempData["Mensaje"] = "Datos registrados";
                }
            }
            return RedirectToAction("Index");
        }
        [Authorize]
        public IActionResult DetallesPafi(int id)
        {
            List<TablaPafi> tb_pafi = new List<TablaPafi>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                tb_pafi = (from p in context.PafisAcademicos
                           join a in context.Academicos on p.IdAcademico equals a.IdAcademicos
                           join s in context.TbSalones on p.IdSalon equals s.IdTbSalones
                           select
                           new TablaPafi
                           {
                               idPafi = p.IdPafis,
                               NombrePafi = p.Nombre,
                               Horario = p.Horario,
                               NombreMaestro = a.Nombre,
                               ApePaterno = a.ApellidoPaterno,
                               ApeMaterno = a.ApellidoMaterno,
                               ClvSalon = s.ClaveSalon,
                           }).ToList();
            }
            TablaPafi correcto = new TablaPafi();
            foreach(TablaPafi item in tb_pafi)
            {
                if(item.idPafi == id)
                {
                    correcto = item;
                    break;
                }
            }
            return View(correcto);
        }
    }
}