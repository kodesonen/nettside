using System;
using Microsoft.EntityFrameworkCore;
using DatabaseHandler.Models;

namespace DatabaseHandler.Dataset
{
    public class DataContext : DbContext
    {
        public DbSet<Pet> Pets { get; set; }
        public DbSet<User> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
            : base(options) { }
    }
}
