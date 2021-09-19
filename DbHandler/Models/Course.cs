using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DbHandler.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Icon { get; set; }
    }
}
