using introduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionCsharp.Controllers
{
    public class MultiplicacionController : Controller
    {
        // GET: Multiplicacion
        public ActionResult Multiplicacion(Multiplicacion mult)
        {
            mult.MultiplicacionRes();

            return View(mult);
        }
    }
}