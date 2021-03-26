using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pregunta7Login.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(ML.Login login){
            if (login.Username == "Admin" && login.Password == "123")
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mensaje = "Error usuario o contraseña incorrecta";
                return View();
            }
        }
    }
}