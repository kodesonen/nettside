using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DbHandler.Models
{
	public class Module
	{
		[Key]
        public int Id { get; set; }
        public int CourseId { get; set; }
        public int Chapter { get; set; }
        public int SubChapter { get; set; }
        public string Author { get; set; }

        /* Publish date and last updated */
        public DateTimeOffset Published { get; set; }
        public DateTimeOffset Updated { get; set; }
        public string LastUpdatedBy { get; set; }

        // Navn på modul
        public string ModuleName { get; set; }
        public string Html { get; set; }

        // Brukes for å notifisere view om man skal oppdatere
        // Eller lage ny modul
        [NotMapped]
        public bool update { get; set; }
    }
}
