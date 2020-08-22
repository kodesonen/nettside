using Microsoft.EntityFrameworkCore;
using DatabaseHandler.Models;
using System.IO;
using Newtonsoft.Json.Linq;

namespace DatabaseHandler.Dataset {

	public class DataContext : DbContext {
		//.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			JObject data = JObject.Parse(File.ReadAllText(@"../WebApp/secrets.json"));
			optionsBuilder.UseMySql(data["DefaultConnection"].ToString());
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Seed();
		}

		// Tables
		public DbSet<User> Users { get; set; }

		public DbSet<Challenge> Challenges { get; set; }
	}
}