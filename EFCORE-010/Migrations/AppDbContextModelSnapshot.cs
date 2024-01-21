﻿// <auto-generated />
using System;
using EFCORE_10.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCORE010.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EFCORE_010.Entites.Enrollment", b =>
                {
                    b.Property<int>("SectionId")
                        .HasColumnType("int");

                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("ParticpantsId")
                        .HasColumnType("int");

                    b.HasKey("SectionId", "StudentId");

                    b.HasIndex("ParticpantsId");

                    b.ToTable("Enrollments", (string)null);
                });

            modelBuilder.Entity("EFCORE_010.Entites.Particpant", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("ParricipantType")
                        .IsRequired()
                        .HasMaxLength(4)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Particpant", (string)null);

                    b.HasDiscriminator<string>("ParricipantType").HasValue("Particpant");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("EFCORE_010.Entites.Schedule", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<bool>("FRI")
                        .HasColumnType("bit");

                    b.Property<bool>("MON")
                        .HasColumnType("bit");

                    b.Property<bool>("SAT")
                        .HasColumnType("bit");

                    b.Property<bool>("SUN")
                        .HasColumnType("bit");

                    b.Property<bool>("THU")
                        .HasColumnType("bit");

                    b.Property<bool>("TUE")
                        .HasColumnType("bit");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("WED")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Schedules", (string)null);
                });

            modelBuilder.Entity("EFCORE_010.Entites.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Sections", (string)null);
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
                });

            modelBuilder.Entity("EFCORE_010.Entites.Coporate", b =>
                {
                    b.HasBaseType("EFCORE_010.Entites.Particpant");

                    b.Property<string>("Company")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("COPR");
                });

            modelBuilder.Entity("EFCORE_010.Entites.Individaul", b =>
                {
                    b.HasBaseType("EFCORE_010.Entites.Particpant");

                    b.Property<string>("University")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("YearOfGraduation")
                        .HasColumnType("int");

                    b.Property<bool>("isIntern")
                        .HasColumnType("bit");

                    b.HasDiscriminator().HasValue("INDV");
                });

            modelBuilder.Entity("EFCORE_010.Entites.Enrollment", b =>
                {
                    b.HasOne("EFCORE_010.Entites.Particpant", "Particpants")
                        .WithMany()
                        .HasForeignKey("ParticpantsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCORE_010.Entites.Section", "Section")
                        .WithMany()
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Particpants");

                    b.Navigation("Section");
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

                    b.HasOne("EFCORE_010.Entites.Schedule", "Schedule")
                        .WithMany("Sections")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("EFCORE_010.Entites.TimeSlot", "TimeSlot", b1 =>
                        {
                            b1.Property<int>("SectionId")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("EndTime")
                                .HasColumnType("time");

                            b1.Property<TimeSpan>("StarTime")
                                .HasColumnType("time");

                            b1.HasKey("SectionId");

                            b1.ToTable("Sections");

                            b1.WithOwner()
                                .HasForeignKey("SectionId");
                        });

                    b.Navigation("Course");

                    b.Navigation("Instructor");

                    b.Navigation("Schedule");

                    b.Navigation("TimeSlot")
                        .IsRequired();
                });

            modelBuilder.Entity("EFCORE_10.Entites.Instructor", b =>
                {
                    b.HasOne("EFCORE_10.Entites.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("EFCORE_10.Entites.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("EFCORE_010.Entites.Schedule", b =>
                {
                    b.Navigation("Sections");
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
