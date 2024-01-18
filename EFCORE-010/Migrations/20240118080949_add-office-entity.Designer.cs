﻿// <auto-generated />
using System;
using EFCORE_10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCORE010.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240118080949_add-office-entity")]
    partial class addofficeentity
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE_10.Entites.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Mathmatics",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "Physics",
                            Price = 2000m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "Chemistry",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "Biology",
                            Price = 1200m
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "CS-50",
                            Price = 3000m
                        });
                });

            modelBuilder.Entity("EFCORE_10.Entites.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Omar Ghanayem",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Amr Shadid",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            Name = "Abood Mukhemar",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            Name = "Abood Saleh",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            Name = "Hamood Khamalan",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("EFCORE_10.Entites.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "building A",
                            OfficeName = "Off-05"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "building B",
                            OfficeName = "Off-06"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Adminstration",
                            OfficeName = "Off-07"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off-08"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "IT Department",
                            OfficeName = "Off-09"
                        });
                });

            modelBuilder.Entity("EFCORE_10.Entites.Instructor", b =>
                {
                    b.HasOne("EFCORE_10.Entites.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EFCORE_10.Entites.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EFCORE_10.Entites.Office", b =>
                {
                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}