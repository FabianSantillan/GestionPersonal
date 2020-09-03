using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SARH.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult AltaPersonal()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult ModificacionPersonal()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult AltaPlazas()

        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}