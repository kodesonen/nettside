using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Auth
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Vennligst oppgi din e-post adresse!")]
        [EmailAddress(ErrorMessage = "Vennligst skriv inn en gyldig e-post adresse!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi ditt fulle navn!")]
        public string Name { get; set; }

		[Required]
		public string University { get; set; }

		[Required]
		public string Study { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi et passord!")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
