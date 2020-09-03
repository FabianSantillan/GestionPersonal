using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARH.Models.DTO
{
    public class PersonFGR
    {
        public string NombreCompleto { get; set; }
        public string FechaNacimiento { get; set; }
        public string RFC { get; set; }
        public string Homoclave { get; set; }
        public string CURP { get; set; }
        public string Sexo { get; set; }
        public string FechaIngresoInstitucion { get; set; }
    }
}