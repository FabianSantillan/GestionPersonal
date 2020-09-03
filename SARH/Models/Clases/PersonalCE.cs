using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SARH.Models.Clases
{
    public class PersonalCE
    {
        [Required]
        public string apellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        [Required]
        public string nombres { get; set; }
        [DataType(DataType.Date)]
        public System.DateTime fechaNacimiento { get; set; }
        [Required]
        [RegularExpression("^[A-Z,Ñ,&]{3,4}[0-9]{2}[0-1][0-9][0-3][0-9][A-Z,0-9]?[A-Z,0-9]?[0-9,A-Z]?$", ErrorMessage = "Ingresa un {0} valido")]
        public string RFC { get; set; }
        public string Homoclave { get; set; }  
        [Required]
        [RegularExpression("^[A-Z][A,E,I,O,U,X][A-Z]{2}[0-9]{2}[0-1][0-9][0-3][0-9][M,H][A-Z]{2}[B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z]{3}[0-9,A-Z][0-9]$", ErrorMessage ="Ingresa un {0} valido")]
        [ExistUserAtribute]
        public string CURP { get; set; }
        public string Sexo { get; set; }
        [DataType (DataType.Date)]
        public System.DateTime fechaIngresoInstitucion { get; set; }
        public Nullable<System.DateTime> fechaRegistro { get; set; }
        public Nullable<byte> idCATAParents { get; set; }
    }

    public class ExistUserAtribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext )
        {
              using (SARHContext db = new SARHContext ())
            {
                string CURP = (string)value;

                if (db.Personal.Where(d=> d.CURP == CURP).Count()>0)
                {
                    return new ValidationResult("El usuario que intenta registrar ya existe");
                }
            }
            return ValidationResult.Success;
        }

    }



}