using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models.Auth
{
    public class RegisterModel
    {
		[Required]
		public string Email { get; set; }

        [Required]
        [MinLength(2, ErrorMessage = "Minium required characters for first name: 2")]
        public string Name { get; set; }

		[Required]
		public string University { get; set; }

		[Required]
		public string Study { get; set; }

        [MinLength(5, ErrorMessage = "Minium required characters for password: 5")]
        [Compare("ConfirmPassword", ErrorMessage = "Passwords does not match")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
