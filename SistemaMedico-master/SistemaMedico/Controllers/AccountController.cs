using Microsoft.AspNetCore.Mvc;

namespace SistemaMedico.Controllers
{
    public class AccountController : Controller
    {
            // GET: /Account/Login
            [HttpGet]
            public IActionResult Login()
            {
                return View();
            }

            // POST: /Account/Login
            [HttpPost]
            public IActionResult Login(string username, string password)
            {
                // Lógica de autenticación aquí
                if (username == "admin" && password == "12345") // Ejemplo básico
                {
                    return RedirectToAction("Index", "Home"); // Redirige al Home después de iniciar sesión
                }

                ViewBag.Error = "Usuario o contraseña incorrectos.";
                return View();
            }

            // GET: /Account/Logout
            public IActionResult Logout()
            {
                // Lógica de cierre de sesión (si aplicas autenticación)
                return RedirectToAction("Login");
            }
        }
    }

