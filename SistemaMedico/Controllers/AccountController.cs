using Microsoft.AspNetCore.Mvc;
using SistemaMedico.Context; // Asegúrate de tener este using para el contexto
using SistemaMedico.Models; // Asegúrate de tener este using para el modelo de usuario
using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;

namespace SistemaMedico.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AccountController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        // POST: /Account/Login
        [HttpPost]
        public async Task<IActionResult> Login(string username, string password)
        {
            // Busca el usuario en la base de datos
            var user = _context.Usuarios
                .FirstOrDefault(u => u.NombreUsuario == username && u.Contraseña == password);

            if (user != null) // Usuario encontrado
            {
                // Crear claims para el usuario
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, username)
                };

                // Crear la identidad y el principal
                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var authProperties = new AuthenticationProperties
                {
                    // Opcional: puedes configurar la duración de la sesión
                };

                // Establecer la cookie de autenticación
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity), authProperties);

                return RedirectToAction("Index", "Home"); // Redirige al Home después de iniciar sesión
            }

            ViewBag.Error = "Usuario o contraseña incorrectos.";
            return View();
        }

        // GET: /Account/Logout
        public async Task<IActionResult> Logout()
        {
            // Cerrar sesión
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login");
        }
    }
}
