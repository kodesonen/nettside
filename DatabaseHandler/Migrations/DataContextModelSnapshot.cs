﻿// <auto-generated />
using DatabaseHandler.Dataset;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DatabaseHandler.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("DatabaseHandler.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<bool>("Admin")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Degree")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FirstName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("Hidden")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastLogin")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("LastName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RegDate")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Study")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Admin = true,
                            Email = "sira@siratech.no",
                            FirstName = "Sirajuddin",
                            Hidden = false,
                            LastName = "Asjad"
                        },
                        new
                        {
                            Id = 2,
                            Admin = true,
                            Email = "danskry@outlook.com",
                            FirstName = "Daniel",
                            Hidden = false,
                            LastName = "Skryseth"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
