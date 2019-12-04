﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;

namespace SGCFIEE.Controllers
{
    public class AcademicosComplementariaController : Controller
    {
        [Authorize]
        public IActionResult VistaOpcionesCatalogos()
        {
            return View();
        }

        [Authorize]
        public IActionResult MostrarPersonal()
        {
            List<TipoPersonal> personal = new List<TipoPersonal>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                personal = context.TipoPersonal.ToList();
            }
            return View(personal);
        }

        [Authorize]
        public IActionResult MostrarPuestos()
        {
            List<TipoPuesto> puestos = new List<TipoPuesto>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                puestos = context.TipoPuesto.ToList();
            }
            return View(puestos);
        }

        [Authorize]
        public IActionResult MostrarLaboratorios()
        {
            List<TipoLaboratorio> laboratorios = new List<TipoLaboratorio>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                laboratorios = context.TipoLaboratorio.ToList();
            }
            return View(laboratorios);
        }

        [Authorize]
        public IActionResult MostrarPeriodos()
        {
            List<TipoPeriodo> periodos = new List<TipoPeriodo>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                periodos = context.TipoPeriodo.ToList();
            }
            return View(periodos);
        }

        [Authorize]
        public IActionResult MostrarTTitulo()
        {
            List<NombreTitulo> titulo = new List<NombreTitulo>();
            using (sgcfieeContext context = new sgcfieeContext())
            {
                titulo = context.NombreTitulo.ToList();
            }
                return View(titulo);
        }

        [Authorize]
        public IActionResult MostrarGTitulo()
        {
            List<GradoTitulo> gradosT = new List<GradoTitulo>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                gradosT = context.GradoTitulo.ToList();
            }
            return View(gradosT);
        }

        [Authorize]
        public IActionResult MostrarDistincionesTA()
        {
            List<TipoDistincionTa> distinciones = new List<TipoDistincionTa>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                distinciones = context.TipoDistincionTa.ToList();
            }
            return View(distinciones);
        }

        [Authorize]
        public IActionResult MostrarCertificacion()
        {
            List<TipoCertificacion> certificacion = new List<TipoCertificacion>();
            using (sgcfieeContext context = new sgcfieeContext())
            {
                certificacion = context.TipoCertificacion.ToList();
            }
            return View(certificacion);
        }

        [Authorize]
        public IActionResult MostrarInstiEmpre()
        {
            List<InstitucionesEmpresas> emp = new List<InstitucionesEmpresas>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                emp = context.InstitucionesEmpresas.ToList();
            }
            return View(emp);
        }

        [Authorize]
        public IActionResult MostrarAcademias()
        {
            List<Academias> academias = new List<Academias>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                academias = context.Academias.ToList();
            }
            return View(academias);
        }

        [Authorize]
        public IActionResult MostrarProTransversales()
        {
            List<ProgramasTrasversales> programas = new List<ProgramasTrasversales>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                programas = context.ProgramasTrasversales.ToList();
            }
            return View(programas);
        }

        [Authorize]
        public IActionResult MostrarTContratacion()
        {
            List<TipoContratacionee> contratacionees = new List<TipoContratacionee>();
            using(sgcfieeContext context = new sgcfieeContext())
            {
                contratacionees = context.TipoContratacionee.ToList();
            }
            return View(contratacionees);
        }

        [Authorize]
        public IActionResult VCarreras()
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                var carreras = context.ProgramaEducativo.ToList();
                ViewData["carreras"] = carreras;
            }
            return View();
        }

        [Authorize]
        public IActionResult TablaMatPE(MapaCurricular map)
        {
            int x = map.IdProgramaEducativo.Value;
            List<TablaMatPE> mapa = new List<TablaMatPE>();
            if(x == 0)
            {
                return RedirectToAction("VCarreras");
            }
            else
            {
                using (sgcfieeContext context = new sgcfieeContext())
                {
                    mapa = (from m in context.MapaCurricular
                            join ee in context.ExperienciaEducativa on m.IdExperienciaEducativa equals ee.IdExperienciaEducativa
                            join ar in context.AreaExperienciaEducativa on ee.IdArea equals ar.IdAreaExperienciaEducativa
                            join pe in context.ProgramaEducativo on m.IdProgramaEducativo equals pe.IdProgramaEducativo
                            select
                            new TablaMatPE
                            {
                                idMapa = m.IdMapaCurricular,
                                nomMat = ee.Nombre,
                                creditos = ee.Creditos.Value,
                                idPE = pe.IdProgramaEducativo,
                                area = ar.Nombre
                            }
                            ).Where(s => s.idPE == x).ToList();
                    var carreras = context.ProgramaEducativo.ToList();
                    ViewData["carreras"] = carreras;
                }
                ViewData["mapa"] = mapa;
                return View();
            }
        }

        //Empiezan los insertar
        [Authorize]
        public IActionResult InsertarPersonal()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPersonal(TipoPersonal personal)
        {
            using(sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoPersonal.Add(personal);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarPuestos()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPuesto(TipoPuesto puesto)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoPuesto.Add(puesto);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarLaboratorios()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearLaboratorio(TipoLaboratorio lab)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoLaboratorio.Add(lab);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarPeriodos()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPeriodo(TipoPeriodo periodo)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoPeriodo.Add(periodo);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarTTitulo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearTTitulo(NombreTitulo titulo)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.NombreTitulo.Add(titulo);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarGTitulo()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearGTitulo(GradoTitulo titulo)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.GradoTitulo.Add(titulo);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarDistincionesTA()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearDistincionTA(TipoDistincionTa distincion)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoDistincionTa.Add(distincion);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarCertificacion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearCertificado(TipoCertificacion certificado)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoCertificacion.Add(certificado);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarIE()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearIE(InstitucionesEmpresas IE)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.InstitucionesEmpresas.Add(IE);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarAcademias()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearAcademias(Academias aca)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.Academias.Add(aca);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarPTransversal()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearPTransversal(ProgramasTrasversales PT)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.ProgramasTrasversales.Add(PT);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }

        [Authorize]
        public IActionResult InsertarTContratacion()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CrearTContratacion(TipoContratacionee ee)
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                context.TipoContratacionee.Add(ee);
                context.SaveChanges();
            }
            return RedirectToAction("VistaOpcionesCatalogos");
        }
    } 
}