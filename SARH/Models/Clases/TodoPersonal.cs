using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SARH.Models.Clases
{
    public class TodoPersonal
    {
        [Display (Name ="Nombre Completo")]
        public string Nombre_Completo { get; set; }
        [Display (Name = "Fecha de Nacimiento")]
        public System.DateTime Fecha_de_Nacimiento { get; set; }
        public string RFC { get; set; }
        public string Homoclave { get; set; }
        public string CURP { get; set; }
        public string Sexo { get; set; }
        [Display(Name = "Fecha Ingreso Institución")]
        public System.DateTime Fecha_Ingreso_Institución { get; set; }
        [Display(Name = "Fecha Registro")]
        public Nullable<System.DateTime> Fecha_Registro { get; set; }
        [Display(Name = "Es papá o mamá")]
        public string Descripcion { get; set; }
    }
}