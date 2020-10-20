using DatabaseHandler.Dataset;
using DatabaseHandler.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Data {

	public class DataContext : DbContext {

		public DataContext(DbContextOptions<DataContext> options) : base(options) {
			Database.EnsureCreated();
		}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			modelBuilder.Seed();
		}

		public DbSet<User> Users { get; set; }

		public DbSet<Challenge> Challenges { get; set; }
	}
}