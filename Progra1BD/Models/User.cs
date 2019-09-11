using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Progra1BD.Models
{
    public class User
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Ingrese su nombre")]
        [StringLength(15, ErrorMessage = "Name should be less than or equal to Fifteen characters.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Enter Your TypeId")]
        [StringLength(1, ErrorMessage = "Name should be less than or equal to one character.")]
        public string TypeDocID { get; set; }
        [Required(ErrorMessage = "Enter Your DocID")]
        [StringLength(10, ErrorMessage = "Name should be less than or equal to ten characters.")]
        public int DocID { get; set; }
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
        [Required(ErrorMessage = "Ingrese su nombre")]
        [StringLength(15, ErrorMessage = "Password should be less than or equal to Fifteen characters.")]
        public string Password { get; set; }
        
        public DateTime Date { get; set; }
    }
}