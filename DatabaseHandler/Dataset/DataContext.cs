using Microsoft.EntityFrameworkCore;
using DatabaseHandler.Models;
using System.IO;
using Newtonsoft.Json.Linq;
using WebApp.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DatabaseHandler.Dataset {

	public class DataContext : IdentityDbContext<KodesonenUser> {

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			JObject data = JObject.Parse(File.ReadAllText("secrets.json"));
			optionsBuilder.UseMySql(data["DefaultConnection"].ToString());
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Seed();
		}

		// Tables
		//public DbSet<User> Users { get; set; }
		public DbSet<KodesonenUser> Users { get; set; }

		public DbSet<Challenge> Challenges { get; set; }
	}
}