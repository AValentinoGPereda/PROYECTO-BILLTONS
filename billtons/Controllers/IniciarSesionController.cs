using Microsoft.AspNetCore.Mvc;

namespace YourProject.Controllers
{
    public class IniciarSesionController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View("IniciarSesion");
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            // Aquí puedes agregar la lógica de autenticación
            if (email == "admin@example.com" && password == "password")
            {
                return RedirectToAction("Index", "Home");
            }

            ViewBag.ErrorMessage = "Correo o contraseña incorrectos.";
            return View();
        }
    }
}
