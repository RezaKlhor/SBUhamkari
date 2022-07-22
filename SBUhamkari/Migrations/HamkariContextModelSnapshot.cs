﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

#nullable disable

namespace SBUhamkari.Migrations
{
    [DbContext(typeof(HamkariContext))]
    partial class HamkariContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Models.Models.CoAnnouncement", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Creatorid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("Projectid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Creatorid");

                    b.HasIndex("Projectid");

                    b.ToTable("CoAnnouncements");
                });

            modelBuilder.Entity("Models.Models.CoApplication", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("Applicantid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("CV")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid>("CoAnnouncementid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Applicantid");

                    b.HasIndex("CoAnnouncementid");

                    b.ToTable("CoApplications");
                });

            modelBuilder.Entity("Models.Models.ContactInfo", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ContactLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("ContactInfos");
                });

            modelBuilder.Entity("Models.Models.EducationInstitute", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("EducationInstitutes");

                    b.HasData(
                        new
                        {
                            id = new Guid("b46c81d0-7f2a-4ceb-90df-5e0d1db9b80d"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(420),
                            Name = "SBU"
                        });
                });

            modelBuilder.Entity("Models.Models.EducationRecord", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Degree")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EducationInstituteid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("EducationState")
                        .HasColumnType("int");

                    b.Property<Guid?>("Personid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("EducationInstituteid");

                    b.HasIndex("Personid");

                    b.ToTable("EducationRecords");
                });

            modelBuilder.Entity("Models.Models.Faculty", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EducationInstituteid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("EducationInstituteid");

                    b.ToTable("Faculties");
                });

            modelBuilder.Entity("Models.Models.Feedback", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Projectid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.HasIndex("Userid");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("Models.Models.Following", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("FollowedID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UserID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.ToTable("Followings");
                });

            modelBuilder.Entity("Models.Models.News", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Userid");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Models.Models.Notification", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("NotifText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NotifTittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("Recieverid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Senderid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Recieverid");

                    b.HasIndex("Senderid");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("Models.Models.Project", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProjectExplain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProjectState")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Models.Models.ProjectFile", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Projectid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("bytes")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.ToTable("ProjectFiles");
                });

            modelBuilder.Entity("Models.Models.ProjectManager", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Projectid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.HasIndex("Userid");

                    b.ToTable("ProjectManagers");
                });

            modelBuilder.Entity("Models.Models.SavedProject", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Projectid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Userid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("id");

                    b.HasIndex("Projectid");

                    b.HasIndex("Userid");

                    b.ToTable("SavedProject");
                });

            modelBuilder.Entity("Models.Models.Skill", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Personid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("SkillLevel")
                        .HasColumnType("int");

                    b.Property<string>("SkillTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Personid");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("Models.Models.TAapplication", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Resume")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("Studentid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Tarequestid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("text")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Studentid");

                    b.HasIndex("Tarequestid");

                    b.ToTable("TAapplications");
                });

            modelBuilder.Entity("Models.Models.TArequest", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("Professorid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tittle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Professorid");

                    b.ToTable("TArequests");
                });

            modelBuilder.Entity("Models.Models.User", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<byte[]>("Avatar")
                        .HasColumnType("varbinary(max)");

                    b.Property<Guid?>("Companyid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("Facultyid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("Companyid");

                    b.HasIndex("Facultyid");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Models.Models.WorkField", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteTime")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("WorkFields");

                    b.HasData(
                        new
                        {
                            id = new Guid("7d3e9ca1-0df7-4584-9e56-0afbb0e4a66b"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(884),
                            Name = "AI"
                        },
                        new
                        {
                            id = new Guid("047cf9e8-c42f-48d4-aa9c-3ebea2823ef5"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(895),
                            Name = "Software"
                        },
                        new
                        {
                            id = new Guid("39ab3ea0-98e7-4936-9347-93d38cbfc1c9"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(899),
                            Name = "Hardware"
                        },
                        new
                        {
                            id = new Guid("5169b695-6f78-47bc-a958-2588500ed345"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(925),
                            Name = "Network"
                        });
                });

            modelBuilder.Entity("PersonWorkField", b =>
                {
                    b.Property<Guid>("PersonID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkfieldID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PersonID", "WorkfieldID");

                    b.HasIndex("WorkfieldID");

                    b.ToTable("PersonWorkField");
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.Property<Guid>("ProjectParticipantsid")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("projectsid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProjectParticipantsid", "projectsid");

                    b.HasIndex("projectsid");

                    b.ToTable("ProjectUser");
                });

            modelBuilder.Entity("ProjectWorkField", b =>
                {
                    b.Property<Guid>("ProjectID")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkfieldID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProjectID", "WorkfieldID");

                    b.HasIndex("WorkfieldID");

                    b.ToTable("ProjectWorkField");
                });

            modelBuilder.Entity("Models.Models.Company", b =>
                {
                    b.HasBaseType("Models.Models.User");

                    b.Property<long>("CompanyIDnumber")
                        .HasMaxLength(10)
                        .HasColumnType("bigint");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Company");

                    b.HasData(
                        new
                        {
                            id = new Guid("6c1a730d-1889-4dcf-86ee-42eea79e6cb5"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(735),
                            Password = "as6d4",
                            Username = "CSEroshd",
                            CompanyIDnumber = 2222222222L,
                            CompanyName = "مرکز رشد دانشکده کامپیوتر"
                        });
                });

            modelBuilder.Entity("Models.Models.Person", b =>
                {
                    b.HasBaseType("Models.Models.User");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("CV")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Firstname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<long>("NationalIdNum")
                        .HasMaxLength(10)
                        .HasColumnType("bigint");

                    b.Property<int>("gender")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Person");
                });

            modelBuilder.Entity("Models.Models.Professor", b =>
                {
                    b.HasBaseType("Models.Models.Person");

                    b.Property<long>("PersonnelID")
                        .HasMaxLength(8)
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Professor");

                    b.HasData(
                        new
                        {
                            id = new Guid("5284988a-2aac-4109-b385-e6b3728fe7fb"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(778),
                            Password = "51324342",
                            Username = "Dr.vahidi",
                            BirthDate = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Mojtaba",
                            Lastname = "Vahidi",
                            NationalIdNum = 1535132133L,
                            gender = 0,
                            PersonnelID = 235133212L
                        });
                });

            modelBuilder.Entity("Models.Models.Student", b =>
                {
                    b.HasBaseType("Models.Models.Person");

                    b.Property<long>("StudentID")
                        .HasMaxLength(8)
                        .HasColumnType("bigint");

                    b.HasDiscriminator().HasValue("Student");

                    b.HasData(
                        new
                        {
                            id = new Guid("3718b60d-8986-427e-b963-8b347abc8a90"),
                            CreateTime = new DateTime(2022, 7, 22, 14, 8, 18, 4, DateTimeKind.Local).AddTicks(573),
                            Password = "324reza",
                            Username = "RezaKlhor",
                            BirthDate = new DateTime(1999, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Firstname = "Reza",
                            Lastname = "Kalhori",
                            NationalIdNum = 3242115120L,
                            gender = 0,
                            StudentID = 96243057L
                        });
                });

            modelBuilder.Entity("Models.Models.CoAnnouncement", b =>
                {
                    b.HasOne("Models.Models.ProjectManager", "Creator")
                        .WithMany("CoAnnouncements")
                        .HasForeignKey("Creatorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Project", "Project")
                        .WithMany("CoAnnouncements")
                        .HasForeignKey("Projectid");

                    b.Navigation("Creator");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Models.Models.CoApplication", b =>
                {
                    b.HasOne("Models.Models.Person", "Applicant")
                        .WithMany("coApplications")
                        .HasForeignKey("Applicantid");

                    b.HasOne("Models.Models.CoAnnouncement", "CoAnnouncement")
                        .WithMany("CoApplications")
                        .HasForeignKey("CoAnnouncementid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Applicant");

                    b.Navigation("CoAnnouncement");
                });

            modelBuilder.Entity("Models.Models.ContactInfo", b =>
                {
                    b.HasOne("Models.Models.User", "User")
                        .WithMany("contactInfos")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Models.EducationRecord", b =>
                {
                    b.HasOne("Models.Models.EducationInstitute", "EducationInstitute")
                        .WithMany("EducationRecords")
                        .HasForeignKey("EducationInstituteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Person", "Person")
                        .WithMany("EducationRecords")
                        .HasForeignKey("Personid");

                    b.Navigation("EducationInstitute");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Models.Models.Faculty", b =>
                {
                    b.HasOne("Models.Models.EducationInstitute", "EducationInstitute")
                        .WithMany("Faculties")
                        .HasForeignKey("EducationInstituteid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EducationInstitute");
                });

            modelBuilder.Entity("Models.Models.Feedback", b =>
                {
                    b.HasOne("Models.Models.Project", "Project")
                        .WithMany("Feedbacks")
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.User", "User")
                        .WithMany("feedbacks")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Models.News", b =>
                {
                    b.HasOne("Models.Models.User", "User")
                        .WithMany("news")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Models.Notification", b =>
                {
                    b.HasOne("Models.Models.User", "Reciever")
                        .WithMany("notifications")
                        .HasForeignKey("Recieverid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Project", "Sender")
                        .WithMany("Notifications")
                        .HasForeignKey("Senderid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Reciever");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("Models.Models.ProjectFile", b =>
                {
                    b.HasOne("Models.Models.Project", "Project")
                        .WithMany("Filess")
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Models.Models.ProjectManager", b =>
                {
                    b.HasOne("Models.Models.Project", "Project")
                        .WithMany("ProjectManagers")
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Models.SavedProject", b =>
                {
                    b.HasOne("Models.Models.Project", "Project")
                        .WithMany()
                        .HasForeignKey("Projectid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.User", "User")
                        .WithMany("SavedProjects")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Project");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Models.Models.Skill", b =>
                {
                    b.HasOne("Models.Models.Person", "Person")
                        .WithMany("skills")
                        .HasForeignKey("Personid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Models.Models.TAapplication", b =>
                {
                    b.HasOne("Models.Models.Student", "Student")
                        .WithMany("TaApplications")
                        .HasForeignKey("Studentid");

                    b.HasOne("Models.Models.TArequest", "Tarequest")
                        .WithMany("TAapplications")
                        .HasForeignKey("Tarequestid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Tarequest");
                });

            modelBuilder.Entity("Models.Models.TArequest", b =>
                {
                    b.HasOne("Models.Models.Professor", "Professor")
                        .WithMany("TArequests")
                        .HasForeignKey("Professorid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Professor");
                });

            modelBuilder.Entity("Models.Models.User", b =>
                {
                    b.HasOne("Models.Models.Company", null)
                        .WithMany("CompanyMembers")
                        .HasForeignKey("Companyid");

                    b.HasOne("Models.Models.Faculty", "Faculty")
                        .WithMany("Users")
                        .HasForeignKey("Facultyid");

                    b.Navigation("Faculty");
                });

            modelBuilder.Entity("PersonWorkField", b =>
                {
                    b.HasOne("Models.Models.WorkField", null)
                        .WithMany()
                        .HasForeignKey("PersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Person", null)
                        .WithMany()
                        .HasForeignKey("WorkfieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectUser", b =>
                {
                    b.HasOne("Models.Models.User", null)
                        .WithMany()
                        .HasForeignKey("ProjectParticipantsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("projectsid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProjectWorkField", b =>
                {
                    b.HasOne("Models.Models.WorkField", null)
                        .WithMany()
                        .HasForeignKey("ProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Models.Project", null)
                        .WithMany()
                        .HasForeignKey("WorkfieldID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Models.Models.CoAnnouncement", b =>
                {
                    b.Navigation("CoApplications");
                });

            modelBuilder.Entity("Models.Models.EducationInstitute", b =>
                {
                    b.Navigation("EducationRecords");

                    b.Navigation("Faculties");
                });

            modelBuilder.Entity("Models.Models.Faculty", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("Models.Models.Project", b =>
                {
                    b.Navigation("CoAnnouncements");

                    b.Navigation("Feedbacks");

                    b.Navigation("Filess");

                    b.Navigation("Notifications");

                    b.Navigation("ProjectManagers");
                });

            modelBuilder.Entity("Models.Models.ProjectManager", b =>
                {
                    b.Navigation("CoAnnouncements");
                });

            modelBuilder.Entity("Models.Models.TArequest", b =>
                {
                    b.Navigation("TAapplications");
                });

            modelBuilder.Entity("Models.Models.User", b =>
                {
                    b.Navigation("SavedProjects");

                    b.Navigation("contactInfos");

                    b.Navigation("feedbacks");

                    b.Navigation("news");

                    b.Navigation("notifications");
                });

            modelBuilder.Entity("Models.Models.Company", b =>
                {
                    b.Navigation("CompanyMembers");
                });

            modelBuilder.Entity("Models.Models.Person", b =>
                {
                    b.Navigation("EducationRecords");

                    b.Navigation("coApplications");

                    b.Navigation("skills");
                });

            modelBuilder.Entity("Models.Models.Professor", b =>
                {
                    b.Navigation("TArequests");
                });

            modelBuilder.Entity("Models.Models.Student", b =>
                {
                    b.Navigation("TaApplications");
                });
#pragma warning restore 612, 618
        }
    }
}