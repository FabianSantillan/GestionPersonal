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
    
    public partial class DatosCredencialInstitucional
    {
        public int idDatosCredencialInstitucional { get; set; }
        public int idPersonal { get; set; }
        public int NoGafete { get; set; }
        public short idCATAPuestos { get; set; }
        public int idCATAAñoVigencia { get; set; }
        public int CodigoAcceso { get; set; }
        public bool TieneResello { get; set; }
        public Nullable<int> idCATAAñoResello { get; set; }
        public byte idCATAEstatusCredencial { get; set; }
    }
}
