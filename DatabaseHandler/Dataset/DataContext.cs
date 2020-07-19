using System;
using Microsoft.EntityFrameworkCore;
using DatabaseHandler.Models;

namespace DatabaseHandler.Dataset
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Tables
        public DbSet<User> Users { get; set; }

        // Data seeding
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
