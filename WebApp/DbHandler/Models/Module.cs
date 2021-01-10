using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DbHandler.Models
{
    public class Module
    {
        [Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int Chapter { get; set; }
        public int SubChapter { get; set; }
        public string Name { get; set; }
    }
}
