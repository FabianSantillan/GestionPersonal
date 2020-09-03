using SARH.Models;
using SARH.Models.Clases;
using SARH.Models.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages.Html;

namespace SARH.Controllers
{
    public class PersonalController : Controller
    {
        private SARHContext db = new SARHContext();
        // GET: Personal
        public ActionResult PersonalAlta()
        {
            {
                var obtenTipoCorreo = db.CATATipoCorreo.ToList();
                SelectList TipoCorreo = new SelectList(obtenTipoCorreo, "idCATATipoCorreo", "DescripcionTipoCorreo");
                ViewBag.listTipoCorreo = TipoCorreo;

                var obtenTipoTelefono = db.CATATipoTelefono.ToList();
                SelectList TipoTelefono = new SelectList(obtenTipoTelefono, "idCATATipoTelefono", "DescripcionTipoTelefono");
                ViewBag.listTipoTelefono = TipoTelefono;

                var obtenAreaFuncional = db.CATAAreasFuncional.ToList();
                SelectList AreaFuncional = new SelectList(obtenAreaFuncional, "idCATAAreasFuncional", "DG_Nombre");
                ViewBag.listAreaFuncional = AreaFuncional;

                var ObtenNumeroPlaza = db.Plazas.Where(x => x.idCATAEstatusPlaza == 0).ToList();
                SelectList NumeroPlaza = new SelectList(ObtenNumeroPlaza, "idPlazas", "numeroPlaza");
                ViewBag.listNumeroPlaza = NumeroPlaza;


                

                //var selected = db.V_PlazasVacantes.Where(x => x.numeroPlaza == nume).First();
                //selected.Selected = true; 

                //ViewBag.NomPuesto = "Jefe de Departamento";


                //var selected = db.V_PlazasVacantes.Where(x => x.idCATAEstatusPlaza == ObtenNumeroPlaza);
                //selected.Selected = true


                //var obtenNumeroPlaza = NumeroPlaza.ToString();
                //var obtenNombrePuesto = db.V_PlazasVacantes.Where(x => x.numeroPlaza == obtenNumeroPlaza).Select(x => x.NombrePuesto).Single();
                //ViewBag.MuestraNombrePuesto = obtenNombrePuesto;


                //var ObtenUserName = User.Identity.Name.ToString();
                //var ObtenidCATAPolicia = db2.AspNetUsers.Where(x => x.UserName == ObtenUserName).Select(x => x.idCATAPolicia).Single();
                //ViewBag.MuestraUserName = ObtenUserName;
            }
            return View();
        }


        //public static SelectList SetSelectedValue(SelectList list, string value)
        //{
        //    if (value != null)
        //    {
        //        var selected = db.V_PlazasVacantes.Where(x => x.NombrePuesto == value).First();
        //        selected.numeroPlaza = true;
        //        return list;
        //    }
        //    return list;
        //}

            public ActionResult GetPlazaLibre ()
        {
            var data = from dls in db.V_PlazasVacantes select new { dls.numeroPlaza, dls.NivelPlaza };
            return Json(data.ToList(), JsonRequestBehavior.AllowGet);
        }



        [HttpPost]
    public ActionResult PersonalAlta(PersonalCE personal)
        {

            if (ModelState.IsValid)
            {              
                var apaterno = personal.apellidoPaterno;
                var amaterno = personal.ApellidoMaterno;
                var nombres = personal.nombres;
                var FNacimiento = personal.fechaNacimiento;
                var RFC = personal.RFC;
                var Homoclave = personal.Homoclave;
                var Curp = personal.CURP;
                var FIngresoinst = personal.fechaIngresoInstitucion;
                var Espapaomama = personal.idCATAParents;

                db.sp_AltaPersonal2(apaterno, amaterno, nombres, FNacimiento, RFC,
                    Homoclave, Curp, FIngresoinst, Espapaomama);

                ViewBag.Message = "Registro Exitoso";
                return RedirectToAction("PersonalAlta");

            }

            return View();
        }

       



            public ActionResult TodoPersonal(TodoPersonal todoPersonal)
        {
            return View(db.V_DetallePersonal.ToList());
        }

        public JsonResult ListadoPersonal()
        {
            SARHContext db = new SARHContext();
            var lista = db.Personal.ToList();
            var nListPerson = new List<PersonFGR>();
            foreach (var item in lista)
            {
                var personal = new PersonFGR
                {
                    NombreCompleto = item.nombreCompleto,
                    FechaNacimiento = item.fechaNacimiento.ToString(),
                    RFC = item.RFC,
                    Homoclave = item.Homoclave,
                    CURP = item.CURP,
                    Sexo = item.Sexo,
                    FechaIngresoInstitucion = item.fechaIngresoInstitucion.ToString()
                };
                nListPerson.Add(personal);
            }
            //var listPerson = lista.Select(p => new { 
            //    p.nombreCompleto,

            //    p.fechaNacimiento,
            //    //p.fechaNacimiento,
            //    p.RFC,
            //    p.Homoclave, 
            //    p.CURP, 
            //    p.Sexo, 
            //    p.fechaIngresoInstitucion }).ToList();
            //var listPerson = lista.Select(x => x.fechaNacimiento.ToString()).ToList();
            return Json(nListPerson, JsonRequestBehavior.AllowGet);
        }
        //public ActionResult ValidaCurp 

        //public ActionResult CatalogoCorreo(CorreoCE tipocorreo)
        //{
        //    List<CorreoCE> lst = null;
        //    using (var db = new SARHContext()) ; 
        //    {

        //           lst= (from d in db.CATATipoCorreo

        //             select new CorreoCE
        //             {
        //                 idCATATipoCorreo=d.idCATATipoCorreo,
        //                 DescripcionTipoCorreo=d.DescripcionTipoCorreo

        //             }).ToList();
        //     }

        //    List<System.Web.Mvc.SelectListItem> items = lst.ConvertAll(d =>
        //     {

        //         return new System.Web.Mvc.SelectListItem()

        //         {
        //             Text = d.DescripcionTipoCorreo.ToString(),
        //             Value = d.idCATATipoCorreo.ToString(),
        //             Selected=false
        //         };
        //     });

        //    ViewBag.tems = items;

        //        return View();

        //}


        public ActionResult TipoCorreo(int? id)
        {
            //using (var db = new SARHContext()) ;
            SARHContext db = new SARHContext();
            var obtenTipoCorreo = db.CATATipoCorreo.ToList();
            SelectList TipoCorreo = new SelectList(obtenTipoCorreo, "idCATATipoCorreo", "DescripcionTipoCorreo");
            ViewBag.listTipoCorreo = TipoCorreo;

            return View();
        }




        public ActionResult PersonalModificacion()
        {
            return View();
        }

        public ActionResult PersonalModificacion1()
        {
            return View();
        }
    }
}