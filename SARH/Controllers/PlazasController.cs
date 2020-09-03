using SARH.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SARH.Controllers
{
    public class PlazasController : Controller
    {
        private SARHContext db = new SARHContext();
        // GET: Plazas
        public ActionResult PlazasAlta()
        {
            {
                var ObtenPuesto = db.CATAPuestos.ToList();
                SelectList Puesto = new SelectList(ObtenPuesto, "idCATAPuestos", "NombrePuesto");
                ViewBag.listPuesto = Puesto;

                //var ObtencodigoPlaza = db.CATACodigosPlaza.ToList();
                //SelectList codigoPlaza = new SelectList(ObtencodigoPlaza, "idCATACodigosPlaza", "descripcion");
                //ViewBag.listcodigoPlaza = codigoPlaza;

           

            }
            return View();
        }

        public ActionResult GetData ()
        {
            var data = from dls in db.CATACodigosPlaza select new { dls.descripcion, dls.NivelPlaza };
            return Json(data.ToList(), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult PlazasAlta (PlazasCE plazas)

        {
            return View();

        }
    }
}