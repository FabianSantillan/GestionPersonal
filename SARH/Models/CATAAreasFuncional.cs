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
    
    public partial class CATAAreasFuncional
    {
        public short idCATAAreasFuncional { get; set; }
        public string DG_Nombre { get; set; }
        public string DG_Iniciales { get; set; }
        public byte idCATAEstatus { get; set; }
        public System.DateTime FechaAlta { get; set; }
        public Nullable<System.DateTime> FechaBaja { get; set; }
    
        public virtual CATAEstatus CATAEstatus { get; set; }
    }
}
