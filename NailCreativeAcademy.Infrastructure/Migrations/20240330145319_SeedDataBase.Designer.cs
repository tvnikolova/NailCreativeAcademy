﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NailCreativeAcademy.Infrastructure.Data;

#nullable disable

namespace NailCreativeAcademy.Infrastructure.Migrations
{
    [DbContext(typeof(NailCreativeDbContext))]
    [Migration("20240330145319_SeedDataBase")]
    partial class SeedDataBase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
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
                            ConcurrencyStamp = "66b08e31-7968-4235-b096-cd17dc7d3f1f",
                            Email = "t_nikolova1985@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "student1@abv.bg",
                            NormalizedUserName = "t_nikolova1985@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEKErmbvEiTTBuAMx8GbcYZljfLo7WI8cALkWH545xfTRnmlSARzoaeSdpDZRcXBf0g==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "9d7ef027-4fc1-4904-a69f-e65bde5c9629",
                            TwoFactorEnabled = false,
                            UserName = "t_nikolova1985@abv.bg"
                        },
                        new
                        {
                            Id = "68a865ce-5b33-4275-a460-dc00683172d2",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "55158165-0366-400d-a56b-d6f07551064d",
                            Email = "student1@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "student1@abv.bg",
                            NormalizedUserName = "student1@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEKVDipW2681dfjty6iNCzhCj/eesI3hS6eH6QjJweKEA3jYih1UwxLMDwKJK7PJ3Jg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "6f979a33-7c6e-4dab-8c4a-148efe79983f",
                            TwoFactorEnabled = false,
                            UserName = "student1@abv.bg"
                        },
                        new
                        {
                            Id = "714e73f4716d4cf9946d494ed0d72cf7",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3cd8885f-6d25-48a9-b30b-39648506a0d5",
                            Email = "student2@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "student2@abv.bg",
                            NormalizedUserName = "student2@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEAIHcfGcuXIPbKUpSW+ZtzvcIgoOe38Mr4yhDkjgNed5veib5RXE3E44MsU6pg2/bg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "78282afc-6a9a-42db-b2c5-46a22e4233be",
                            TwoFactorEnabled = false,
                            UserName = "student2@abv.bg"
                        },
                        new
                        {
                            Id = "cf756f58ca9146f2889a54a32cde2dfc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "879d315e-8058-4ee1-bb40-5aa14cdf2d7e",
                            Email = "client1@abv.bg",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "client1@abv.bg",
                            NormalizedUserName = "client1@abv.bg",
                            PasswordHash = "AQAAAAEAACcQAAAAEGpGPkP8Nd8ZtKtY4zzS52RaaHKMROr2pEQxfK7KYp2YUHlG8wS2g3/inBNCIhWuPQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "cc62363b-b6e4-4bc0-8454-1634c2b8d7e7",
                            TwoFactorEnabled = false,
                            UserName = "client1@abv.bg"
                        });
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
                            PhoneNumber = "0888 222 555"
                        },
                        new
                        {
                            Id = 2,
                            Address = "София, пл. \"Света Неделя\" 5",
                            ClientId = "68a865ce-5b33-4275-a460-dc00683172d2",
                            PhoneNumber = "0888 222 555"
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
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
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

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Feedback", b =>
                {
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

                    b.Navigation("Course");

                    b.Navigation("FeedbackBoard");
                });

            modelBuilder.Entity("NailCreativeAcademy.Infrastructure.Data.Models.Saloon", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", "Client")
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
