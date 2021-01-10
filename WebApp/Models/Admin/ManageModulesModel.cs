using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models.Admin
{
    public class ManageModulesModel
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        [Required]
        public string Icon { get; set; }
    }
}
