using introduccionCsharp.Models;
using introduccionCsharp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introduccionCsharp.Controllers
{
    public class PruebaController : Controller
    {
        // GET: Prueba
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Suma()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Suma(string x, string y, string r1)
        {
            int res = Convert.ToInt16(x) + Convert.ToInt16(y);
            ViewBag.Res = Convert.ToString(res);

            return View();
        }

        public ActionResult Calculos(OperasBas op)
        {
            op.Suma();

            return View(op);
        }

        public ActionResult MuestraPeliculas()
        {
            // Instanciamos el Service para acceder a sus métodos
            var PeliculasService = new PeliculasService();

            // En el Service accedemos al método ObstenerPelicula() y me traiga los objetos como lista
            var model = PeliculasService.ObtenerPelicula();

            return View(model);
        }
    }
}