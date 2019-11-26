using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using System.Diagnostics;

namespace SGCFIEE.Controllers
{
    public class EstudiantesInformacionController : Controller
    {
        public IActionResult Index()
        {
            List<TablaAlumno> ListAlumno = new List<TablaAlumno>();
            using (sgcfieeContext context = new sgcfieeContext()) {
                ListAlumno = (from d in context.DatosPersonales join
                              a in context.Alumnos on d.IdDatosPersonales equals a.RDatosPerson
                              join p in context.ProgramaEducativo on a.RProgramaEducativo equals p.IdProgramaEducativo
                              select
                              new TablaAlumno {
                                  id = a.IdAlumnos,
                                  Nombre = d.Nombre,
                                  ApellidoPaterno = d.ApellidoPaterno,
                                  ApellidoMaterno = d.ApellidoMaterno,
                                  Matricula = a.Matricula,
                                  NombrePro = p.Nombre
                              }
                              ).ToList();
                return View(ListAlumno);
            }

        }
        [HttpGet]
        public IActionResult Crear()
        {
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var x = context.ProgramaEducativo.ToList();
                ViewData["progra"] = x;
                return View();
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Crear(Alumnos datos) {
            using (sgcfieeContext context = new sgcfieeContext()) {
                context.Alumnos.Add(datos);
                context.SaveChanges();
                TempData["Mensaje"] = "Datos registrados";
                return RedirectToAction("Index");

            }
        }
        [HttpGet]
        public IActionResult Editar(int id)
        {
            List<DatosAlumno> ListAlumno = new List<DatosAlumno>();
            DatosAlumno datosalumno = new DatosAlumno();
            using (sgcfieeContext context = new sgcfieeContext()) {
                var x = context.ProgramaEducativo.ToList();
                ViewData["programa"] = x;
                var alumno = context.Alumnos.Where(s => s.IdAlumnos == id).Single();
                var datos = context.DatosPersonales.Where(s => s.IdDatosPersonales == id).Single();
                datosalumno.IdDatosPersonales = id;
                datosalumno.Nombre = datos.Nombre;
                datosalumno.ApellidoPaterno = datos.ApellidoPaterno;
                datosalumno.ApellidoMaterno = datos.ApellidoMaterno;
                datosalumno.Correo = datos.Correo;
                datosalumno.FechaNacimiento = datos.FechaNacimiento;
                datosalumno.Nacionalidad = datos.Nacionalidad;
                datosalumno.EstadoCivil = datos.EstadoCivil;
                datosalumno.Genero = datos.Genero;
                datosalumno.Curp = datos.Curp;
                datosalumno.Calle = datos.Calle;
                datosalumno.Colonia = datos.Colonia;
                datosalumno.Ciudad = datos.Ciudad;
                datosalumno.Municipio = datos.Municipio;
                datosalumno.Estado = datos.Estado;
                datosalumno.Pais = datos.Pais;
                datosalumno.CodigoPostal = datos.CodigoPostal;
                datosalumno.Telefono = datos.Telefono;
                datosalumno.RecidenciaActual = datos.RecidenciaActual;
                datosalumno.Trabaja = datos.Trabaja;
                datosalumno.IngresoMensual = datos.IngresoMensual;
                datosalumno.Matricula = alumno.Matricula;
                datosalumno.CorreoInstitucional = alumno.CorreoInstitucional;
                datosalumno.RDatosPerson = datos.IdDatosPersonales;
                datosalumno.AnioIngreso = alumno.AnioIngreso;
                datosalumno.Modalidad = alumno.Modalidad;
                datosalumno.Bachillerato = alumno.Bachillerato;
                
                return View(datosalumno);
            }

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Editar(DatosAlumno alumno)
        {
            DatosPersonales datos = new DatosPersonales();
            Alumnos alum = new Alumnos();
            ProgramaEducativo progra = new ProgramaEducativo();
            using (sgcfieeContext context = new sgcfieeContext())
            {
                datos.IdDatosPersonales = alumno.IdDatosPersonales;
                datos.Nombre = alumno.Nombre;
                datos.ApellidoPaterno = alumno.ApellidoPaterno;
                datos.ApellidoMaterno = alumno.ApellidoMaterno;
                datos.Correo = alumno.Correo;
                datos.FechaNacimiento = alumno.FechaNacimiento;
                datos.Nacionalidad = alumno.Nacionalidad;
                datos.EstadoCivil = alumno.EstadoCivil;
                datos.Genero = alumno.Genero;
                datos.Curp = alumno.Curp;
                datos.Calle = alumno.Calle;
                datos.Colonia = alumno.Colonia;
                datos.Ciudad = alumno.Ciudad;
                datos.Municipio = alumno.Municipio;
                datos.Estado = alumno.Estado;
                datos.Pais = alumno.Pais;
                datos.CodigoPostal = alumno.CodigoPostal;
                datos.Telefono = alumno.Telefono;
                datos.RecidenciaActual = alumno.RecidenciaActual;
                datos.Trabaja = alumno.Trabaja;
                datos.IngresoMensual = alumno.IngresoMensual;
                alum.IdAlumnos = alumno.IdDatosPersonales;
                alum.RDatosPerson = alumno.IdDatosPersonales;
                alum.Matricula = alumno.Matricula;
                alum.CorreoInstitucional = alumno.CorreoInstitucional;
                alum.Modalidad = alumno.Modalidad;
                alum.RProgramaEducativo = alumno.RProgramaEducativo;
                alum.AnioIngreso = alumno.AnioIngreso;
                alum.Bachillerato = alumno.Bachillerato;
               
                context.Alumnos.Update(alum);
                context.SaveChanges();
                TempData["Mensaje"] = "La infromacion ha sido actualizada";
                context.DatosPersonales.Update(datos);
                context.SaveChanges();
                TempData["Mensaje"] = "La infromacion ha sido actualizada";
                return RedirectToAction("Index");
            }

        }
        [HttpGet]
        public IActionResult Detalles(int id)
        {
            
            CompletoAlumnos datosalumno = new CompletoAlumnos();
            using (sgcfieeContext context = new sgcfieeContext())
            {
                var alumno = context.Alumnos.Where(s => s.IdAlumnos == id).Single();
                var datos = context.DatosPersonales.Where(s => s.IdDatosPersonales == id).Single();
                datosalumno.IdDatosPersonales = id;
                datosalumno.Nombre = datos.Nombre;
                datosalumno.ApellidoPaterno = datos.ApellidoPaterno;
                datosalumno.ApellidoMaterno = datos.ApellidoMaterno;
                datosalumno.Correo = datos.Correo;
                datosalumno.FechaNacimiento = datos.FechaNacimiento;
                datosalumno.Nacionalidad = datos.Nacionalidad;
                datosalumno.EstadoCivil = datos.EstadoCivil;
                datosalumno.Genero = datos.Genero;
                datosalumno.Curp = datos.Curp;
                datosalumno.Calle = datos.Calle;
                datosalumno.Colonia = datos.Colonia;
                datosalumno.Ciudad = datos.Ciudad;
                datosalumno.Municipio = datos.Municipio;
                datosalumno.Estado = datos.Estado;
                datosalumno.Pais = datos.Pais;
                datosalumno.CodigoPostal = datos.CodigoPostal;
                datosalumno.Telefono = datos.Telefono;
                datosalumno.RecidenciaActual = datos.RecidenciaActual;
                datosalumno.Trabaja = datos.Trabaja;
                datosalumno.IngresoMensual = datos.IngresoMensual;
                datosalumno.Matricula = alumno.Matricula;
                datosalumno.CorreoInstitucional = alumno.CorreoInstitucional;
                datosalumno.AnioIngreso = alumno.AnioIngreso;
                datosalumno.Modalidad = alumno.Modalidad;
                datosalumno.Bachillerato = alumno.Bachillerato;

                return View(datosalumno);
            }

        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}