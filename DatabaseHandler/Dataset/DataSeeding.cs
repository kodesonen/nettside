using System;
using DatabaseHandler.Models;
using Microsoft.EntityFrameworkCore;

namespace DatabaseHandler.Dataset
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // Users
            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, FirstName = "Sirajuddin", LastName = "Asjad", Email = "sira@siratech.no", Admin = true },
                new User { Id = 2, FirstName = "Daniel", LastName = "Skryseth", Email = "danskry@outlook.com", Admin = true }
            );
        }
    }
}
