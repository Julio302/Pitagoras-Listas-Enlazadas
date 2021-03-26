using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pregunta10REST_API.Controllers
{
    public class FotosController : Controller
    {
        // GET: Fotos
        [HttpGet]
        public ActionResult Fotos()
        {
            return View();
        }
    }
}