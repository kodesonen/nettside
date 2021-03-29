using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Settings
{
    public class EditPasswordModel
    {
        [Required(ErrorMessage = "Vennligst oppgi et passord!")]
        [DataType(DataType.Password)]
        public string CurrentPassword { get; set; }

        [Required(ErrorMessage = "Vennligst oppgi et passord!")]
        [Compare("ConfirmPassword", ErrorMessage = "Dine passord matcher ikke. Vennligst prøv igjen!")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Vennligst bekreft ditt passord!")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
