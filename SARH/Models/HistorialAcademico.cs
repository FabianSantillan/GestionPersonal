//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SARH.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class HistorialAcademico
    {
        public int idHistorialAcademico { get; set; }
        public int idPersonal { get; set; }
        public short idCATANivelEstudios { get; set; }
        public Nullable<short> idCATACarreras { get; set; }
        public Nullable<System.DateTime> FechaInicio { get; set; }
        public Nullable<System.DateTime> FechaConcluye { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public string cedula { get; set; }
        public Nullable<byte> idCATANombreEscuela { get; set; }
        public Nullable<byte> idCATASituacionAcademica { get; set; }
    }
}
