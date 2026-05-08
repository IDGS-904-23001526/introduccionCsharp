using introduccionCsharp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionCsharp.Controllers
{
    public class DistanciaController : Controller
    {
        // GET: Distancia
        public ActionResult Distancia(Distancia d)
        {
            d.DistanciaRes();

            return View(d);
        }
    }
}

// Operacion de 