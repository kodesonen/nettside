using System;
using System.ComponentModel.DataAnnotations;

namespace WebApp.DbHandler.Models
{
    public class Challenge
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int Downloads { get; set; }
        public string Img { get; set; }
        public string Pdf { get; set; }
        public string Git { get; set; }
    }
}
