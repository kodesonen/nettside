using System;
using Microsoft.EntityFrameworkCore;
using WebApp.DbHandler.Models;

namespace WebApp.DbHandler
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.Entity<User>().HasData(
                new User { UserName = "Sirajuddin Asjad", Private = false },
                new User { UserName = "Sirapudding", Private = true },
                new User { UserName = "Stian Håve", Private = false }
            );

            // Challenges
            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, Title = "Test challenge", Description = "This is a test!", Downloads = 0 },
                new Challenge { Id = 2, Title = "Test challenge 2", Description = "This is a test!", Downloads = 99 }
            );

            // Courses
            modelBuilder.Entity<Course>().HasData(
                new Course { Id = 1, Name = "Test course", Description = "This is a test!", Icon = "fas fa-code" },
                new Course { Id = 2, Name = "Another test", Description = "This is a test!", Icon = "fas fa-cogs" }
            );
        }
    }
}
