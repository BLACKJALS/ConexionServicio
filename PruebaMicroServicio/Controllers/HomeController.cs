using PruebaMicroServicio.PruebaTutorialServicio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PruebaMicroServicio.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ServicioPruebaClient client = new ServicioPruebaClient();
            var correo = client.enviarCorreo("prueba@prueba.co");
            return View();
        }

        public ActionResult About() {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact() {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}