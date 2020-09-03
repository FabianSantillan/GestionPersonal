using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARH.Models.Clases
{
    public class PlazasCE
    {
        public int idPlazas { get; set; }
        public string numeroPlaza { get; set; }
        public short idCATAPuestos { get; set; }
        public short idCATACodigosPlaza { get; set; }
        public string CargoEstructura { get; set; }
        public string ClavePresupuestal { get; set; }
        public byte idCATAEstatusPlaza { get; set; }
        public System.DateTime fechaRegistro { get; set; }

        public virtual CATACodigosPlaza CATACodigosPlaza { get; set; }
        public virtual CATAEstatusPlaza CATAEstatusPlaza { get; set; }
        public virtual CATAPuestos CATAPuestos { get; set; }
    }
}