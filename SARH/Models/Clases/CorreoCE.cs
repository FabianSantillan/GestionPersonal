using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SARH.Models.Clases
{
    public class CorreoCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CorreoCE()
        {
            this.Correos = new HashSet<Correos>();
        }

        public byte idCATATipoCorreo { get; set; }
        public string DescripcionTipoCorreo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Correos> Correos { get; set; }
    }
}