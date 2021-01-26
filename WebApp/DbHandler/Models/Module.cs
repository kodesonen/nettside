using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApp.DbHandler.Models {

	public class Module {

		[Key]
		public int Id { get; set; }

		public int CourseId { get; set; }
		public int Chapter { get; set; }
		public int SubChapter { get; set; }

		//Navn på modul
		public string ModuleName { get; set; }

		public string Html { get; set; }

		//Dato modul ble publisert
		public DateTimeOffset Published { get; set; }

		//Dato modul ble sist oppdatert
		public DateTimeOffset Updated { get; set; }

		//Original oppretter av dokument
		public string Forfatter { get; set; }

		//Forfatter som gjorde siste opdatering
		public string UpdateForfatter { get; set; }

		//Brukes for å notifisere view om man skal oppdatere
		//Eller lage ny modul
		[NotMapped]
		public bool update { get; set; }
	}
}