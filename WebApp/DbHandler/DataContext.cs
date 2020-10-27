using Microsoft.EntityFrameworkCore;
using WebApp.DbHandler;
using WebApp.DbHandler.Models;
using System.IO;
using Newtonsoft.Json.Linq;
using WebApp.Models.Auth;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace WebApp.DbHandler
{
    public class DataContext : IdentityDbContext<User>
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //JObject data = JObject.Parse(File.ReadAllText("secrets.json"));
            //optionsBuilder.UseMySql(data["DefaultConnection"].ToString());
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

        // Tables
        public DbSet<User> Users { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Challenge> Challenges { get; set; }
    }
}
