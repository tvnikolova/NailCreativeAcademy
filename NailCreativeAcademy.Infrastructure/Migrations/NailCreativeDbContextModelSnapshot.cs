﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NailCreativeAcademy.Infrastructure.Data;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    [DbContext(typeof(NailCreativeDbContext))]
    partial class NailCreativeDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "b8b63dd7e8f14a01b3d4ef4bb901b2e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "e69b8920-9a23-4d61-9357-a0fb8726db4c",
                            Email = "t_nikolova1985@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "T_NIKOLOVA1985@ABV.BG",
                            NormalizedUserName = "T_NIKOLOVA1985@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAENTsB+Taa0kqSy0XuH3nmRwj2YXAxn808hUQWlKAkhd8JIDDy0cVHbhh24Xb8g2XIg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "185508eb-2532-4ddf-adb3-20b5ad59cfde",
                            TwoFactorEnabled = false,
                            UserName = "t_nikolova1985@abv.bg"
                        },
                        new
                        {
                            Id = "68a865ce-5b33-4275-a460-dc00683172d2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2b100b13-52ee-49c2-b03a-5c13f1ea9a5b",
                            Email = "student1@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT1@ABV.BG",
                            NormalizedUserName = "STUDENT1@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEPVzFlDvHosuphvgErOzKii467LR+cwPizoB9YIFIA+H8Q1B4WlPi64MPFlzXOYxew==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "ecbd8b2a-1b3c-46ed-a06b-4b7f8e8ddace",
                            TwoFactorEnabled = false,
                            UserName = "student1@abv.bg"
                        },
                        new
                        {
                            Id = "714e73f4716d4cf9946d494ed0d72cf7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f850017d-3610-449e-b6a4-a045f103489f",
                            Email = "student2@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "STUDENT2@ABV.BG",
                            NormalizedUserName = "STUDENT2@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEGtooSf2KMoywXWnzIPbPEqi3jC9fEUf46Y9nwf1RpGmSufXBgP1bGg0wMyQoailxQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "b8de93bb-ddf6-464d-8fdd-4237cd14bb86",
                            TwoFactorEnabled = false,
                            UserName = "student2@abv.bg"
                        },
                        new
                        {
                            Id = "cf756f58ca9146f2889a54a32cde2dfc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8575222e-69a8-4fed-8cc3-aa65638ab35e",
                            Email = "client1@abv.bg",
                            EmailConfirmed = false,
                            FirstName = "",
                            LastName = "",
                            LockoutEnabled = false,
                            NormalizedEmail = "CLIENT1@ABV.BG",
                            NormalizedUserName = "CLIENT1@ABV.BG",
                            PasswordHash = "AQAAAAEAACcQAAAAEOmPfPH449pdArxAfZ/dtAbLKKRo6S1VZAYbBELEf2cDt5sMhSoURnF2IXD5fsxZ9g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "005b6c69-22bd-460e-a845-041861b5d4d3",
                            TwoFactorEnabled = false,
                            UserName = "client1@abv.bg"
                        });
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Course identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CourseTypeId")
                        .HasColumnType("int")
                        .HasComment("Course type");

                    b.Property<string>("Details")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)")
                        .HasComment("Course details");

                    b.Property<string>("Duration")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Course program");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2")
                        .HasComment("End date of course");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Name of course");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Course price");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)")
                        .HasComment("Course program");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2")
                        .HasComment("Date of starting course");

                    b.Property<int>("TrainerId")
                        .HasColumnType("int")
                        .HasComment("Trainer's id");

                    b.HasKey("Id");

                    b.HasIndex("CourseTypeId");

                    b.HasIndex("TrainerId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.CourseType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Course type identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)")
                        .HasComment("Name of course type");

                    b.HasKey("Id");

                    b.ToTable("CoursesTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Начинаещи"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Напреднали"
                        });
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.EnrolledStudent", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasComment("Student's course idenfitier");

                    b.Property<string>("StudentId")
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Enrolled student's identifier");

                    b.HasKey("CourseId", "StudentId");

                    b.HasIndex("StudentId");

                    b.ToTable("EnrolledStudents");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Feedback identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Identifier of the client to which the feedback is.");

                    b.Property<int>("CourseId")
                        .HasColumnType("int")
                        .HasComment("Identifier of the course to which the feedback is.");

                    b.Property<int>("FeedbackBoardId")
                        .HasColumnType("int")
                        .HasComment("FeedbackBoard identifier");

                    b.Property<string>("Review")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Content of the review");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.HasIndex("CourseId");

                    b.HasIndex("FeedbackBoardId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.FeedbackBoard", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Feedback's board identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("FeedbacksBoards");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Saloon", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Saloon identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("Saloon's address");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("Client identifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Saloon's name");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Saloon's phone number");

                    b.HasKey("Id");

                    b.HasIndex("ClientId");

                    b.ToTable("Saloons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Пазарджик, бул. \"България\" 2",
                            ClientId = "cf756f58ca9146f2889a54a32cde2dfc",
                            Name = "Nail Creative Saloon",
                            PhoneNumber = "+359888222555"
                        },
                        new
                        {
                            Id = 2,
                            Address = "София, пл. \"Света Неделя\" 5",
                            ClientId = "68a865ce-5b33-4275-a460-dc00683172d2",
                            Name = "Nail Creative-S Saloon",
                            PhoneNumber = "+359888333555"
                        });
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Trainer identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("About")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasComment("Trainer's information");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Trainer's names");

                    b.HasKey("Id");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            About = "Екатерина Николова е обучител в академията от 3 години. Тя е със 7 години опит в областта на маникюра. Има няколко първи места от спечелени международни конкурси за маникюр ",
                            Name = "Екатерина Николова"
                        },
                        new
                        {
                            Id = 2,
                            About = "Елена Кушниренко е международен съдия и обучител. Тя е майстор с над 10 години опит в областта на маникюра. Създала е програми за основни и надграждащи курсове. Елена е международен съдия и многократен победител в международни конкурси за ноктопластика.",
                            Name = "Елена Кушниренко"
                        },
                        new
                        {
                            Id = 3,
                            About = "Диана Александровна е обучител по маникюр и педикюр. Тя е с над 11 години опит и е сертифицирана в Украйна. Диана провежда курсове по класически маникюр, класически педикюр и ноктопластика с гел.",
                            Name = "Диана Александровна"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Course", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.CourseType", "CourseType")
                        .WithMany("Courses")
                        .HasForeignKey("CourseTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.Trainer", "Trainer")
                        .WithMany("Courses")
                        .HasForeignKey("TrainerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CourseType");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.EnrolledStudent", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.Course", "Course")
                        .WithMany("EnrolledStudents")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Feedback", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.FeedbackBoard", "FeedbackBoard")
                        .WithMany("Feedbacks")
                        .HasForeignKey("FeedbackBoardId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");

                    b.Navigation("Course");

                    b.Navigation("FeedbackBoard");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Saloon", b =>
                {
                    b.HasOne("NailCreativeAcademy.Infrastructure.Data.Models.ApplicationUser", "Client")
                        .WithMany()
                        .HasForeignKey("ClientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Client");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Course", b =>
                {
                    b.Navigation("EnrolledStudents");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.CourseType", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.FeedbackBoard", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Trainer", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
