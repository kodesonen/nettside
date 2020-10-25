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
                new User { UserName = "Sirajuddin Asjad" },
                new User { UserName = "Stian Håve" }
            );

            // Challenges
            modelBuilder.Entity<Challenge>().HasData(
                new Challenge { Id = 1, Title = "Test challenge", Description = "This is a test!", Downloads = 0 },
                new Challenge { Id = 2, Title = "Test challenge 2", Description = "This is a test!", Downloads = 99 }
            );
        }
    }
}
