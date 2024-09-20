using Microsoft.AspNetCore.Mvc;
using loginBasico.Models;
using System.Reflection.Metadata.Ecma335;
namespace loginBasico.Controllers
{
    public class CuentaController : Controller
    {
        private static string usuario_V = "nicolas";
        private static string password_V = "123456";

        //para retornar vista
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(usuario usuario)
        {
            if (usuario.User == usuario_V && usuario.Pass == password_V)
            {
                return RedirectToAction("Index", "Home");
                Console.WriteLine("funciona");
                Console.WriteLine("Swgundo cambio");
            }
            else
            {
                ViewBag.ErrorMessage = "Usuario o contraseña incorrectos. Inténtalo de nuevo.";
                return RedirectToAction("Index", "Home");
            }

        }

      
    }
}
