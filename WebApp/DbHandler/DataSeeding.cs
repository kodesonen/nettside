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
                new User 
                { 
                    UserName = "Sirajuddin Asjad", 
                    Private = false, 
                    UrlName = "sirasjad", 
                    StaffPosition = "Systemansvarlig", 
                    University = "USN",
                    Study = "Masterstudent",
                    Description = "Dette er en beskrivelse!",
                    Website = "https://siratech.no",
                    GitHub = "https://github.com/sirasjad",
                    LinkedIn = "https://www.linkedin.com/in/sirajuddin97"
                },

                new User 
                { 
                    UserName = "Stian Håve", 
                    Private = false, 
                    UrlName = "stianh"
                }
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

            // Modules
            modelBuilder.Entity<Module>().HasData(
                new Module { Id = 1, ModuleName = "Test module", CourseId = 1, Chapter = 1, SubChapter = 1 },
                new Module { Id = 2, ModuleName = "Another module", CourseId = 1, Chapter = 1, SubChapter = 2 }
            );
        }
    }
}