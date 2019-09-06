using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Progra1BD.Models
{
    public class Beneficiarie
    {
        [Key]
        [Required] 
        public int ID { get; set; }
        [Required(ErrorMessage =  "El nombre es requerido")]
        [StringLength(100,ErrorMessage = "Longitud máxima 100")]
        public string Name { get; set; }
        [Required(ErrorMessage =  "La fecha es requerida")]
        public int TypeDocID { get; set; }
        [Required(ErrorMessage =  "La fecha es requerida")]
        public int DocID { get; set; }
        [Required(ErrorMessage =  "La fecha es requerida")]
        public int TipoParentesco { get; set; }
        
        public int idCuenta { get; set; }
        
        [Required(ErrorMessage =  "La fecha es requerida")]
        [StringLength(100,ErrorMessage = "Longitud máxima 100")]
        public string Date { get; set; }
        
        [Required(ErrorMessage = "Your must provide a Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{2})$", ErrorMessage = "Not a valid Mobile number")]
        public int Mobile1 { get; set; }
        
        [Required(ErrorMessage = "Your must provide a Mobile Number")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{2})$", ErrorMessage = "Not a valid Mobile number")]
        public int Mobile2 { get; set; }
        
        [Required(ErrorMessage = "Enter Your email")]
        [RegularExpression(@"^[\w-\._\+%]+@(?:[\w-]+\.)+[\w]{2,6}$", ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }
        
        [Required(ErrorMessage = "Ingrese su username")]
        [StringLength(15, ErrorMessage = "username should be less than or equal to Fifteen characters.")]
        public string Username { get; set; }

        public bool Activo { get; set; }
        
        [Required(ErrorMessage = "Ingrese el porcentaje")]
        public int Porcentaje { get; set; }

        public DateTime fechaActivo { get; set; }
        
        public DateTime fechaDesactivo { get; set; }

        [Required(ErrorMessage = "Ingrese su nombre")]
        [StringLength(15, ErrorMessage = "Password should be less than or equal to Fifteen characters.")]
        public string Password { get; set; }
        
    }
}