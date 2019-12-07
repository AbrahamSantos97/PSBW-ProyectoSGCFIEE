using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using SGCFIEE.Models;
using Microsoft.AspNetCore.Authentication;
using System.Security.Cryptography;
using System.Text;

namespace SGCFIEE.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Principal(SGCFIEE.Models.UsuarioLogin user)
        {
            var x = 2;
            Usuarios usu = new Usuarios();
            String pass = string.Concat(user.matricula,user.password);
            SHA1 sha1 = new SHA1CryptoServiceProvider();
            byte[] input = (new UnicodeEncoding()).GetBytes(pass);
            byte[] hash = sha1.ComputeHash(input);
            string passwo = Convert.ToBase64String(hash);
            user.password = passwo;
            using(sgcfieeContext context = new sgcfieeContext())
            {
                usu = context.Usuarios.Where(e => e.Nombre.Equals(user.matricula) && e.Contrasenia.Equals(user.password)).SingleOrDefault();
                if (usu.Nombre.Equals(user.matricula) && usu.Contrasenia.Equals(user.password))
                {
                    x = 1;
                }
            }
            if (x == 1)
            {
                var claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.Name, user.matricula));
                var userIdentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(userIdentity);
                HttpContext.SignInAsync("PKAT", principal);
                HttpContext.Session.SetString("Matricula", usu.Nombre);
                HttpContext.Session.SetInt32("TipoUsuario", usu.Tipo);
                if(usu.Tipo == 3)
                {
                    HttpContext.Session.SetInt32 ("IdUsu", usu.IdAlumno.Value);
                }
                else
                {
                    HttpContext.Session.SetInt32("IdUsu", usu.IdAcademico.Value);
                }
                
                return RedirectToAction("Default");
            }
            else
            {
                return RedirectToAction("Index");
            }
            //return View();
        }

        public IActionResult Default()
        {
            ViewData["tipo"] = (int)HttpContext.Session.GetInt32("TipoUsuario");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Logout()
        {
            HttpContext.SignOutAsync("PKAT");
            HttpContext.Session.Remove("Matricula");
            HttpContext.Session.Remove("TipoUsuario");
            HttpContext.Session.Remove("IdUsu");
            return RedirectToAction("Index");

        }
    }
}
