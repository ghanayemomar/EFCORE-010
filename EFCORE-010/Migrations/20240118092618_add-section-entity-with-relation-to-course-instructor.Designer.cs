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
    [Migration("20240118092618_add-section-entity-with-relation-to-course-instructor")]
    partial class addsectionentitywithrelationtocourseinstructor
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE_010.Entites.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "S_MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "S_MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InstructorId = 1,
                            SectionName = "S_PH1"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InstructorId = 3,
                            SectionName = "S_PH2"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InstructorId = 2,
                            SectionName = "S_CH1"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "S_CH2"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S_BI1"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InstructorId = 5,
                            SectionName = "S_BI2"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS1"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InstructorId = 5,
                            SectionName = "S_CS2"
                        },
                        new
                        {
                            Id = 11,
                            CourseId = 5,
                            InstructorId = 4,
                            SectionName = "S_CS3"
                        });
                });

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

            modelBuilder.Entity("EFCORE_010.Entites.Section", b =>
                {
                    b.HasOne("EFCORE_10.Entites.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCORE_10.Entites.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("EFCORE_10.Entites.Instructor", b =>
                {
                    b.HasOne("EFCORE_10.Entites.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EFCORE_10.Entites.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EFCORE_10.Entites.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EFCORE_10.Entites.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("EFCORE_10.Entites.Office", b =>
                {
                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
