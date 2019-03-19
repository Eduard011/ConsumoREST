using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ConsumeREST.Extensiones;
using ConsumeREST.Models;

namespace ConsumeREST.Controllers
{
    public class ServiciosController : Controller
    {
        // GET: Servicios
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Servicios()
        {
            return View();
        }

        [HttpGet]
        public ActionResult ConsumirConceptos(int service)
        {
            ConsumoServicios servicios = new ConsumoServicios(service);
            Principal principal = servicios.ConsumirREST();

            return Json(principal.respuesta, JsonRequestBehavior.AllowGet);
        }
    }
}