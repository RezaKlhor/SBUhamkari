﻿
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models
{
    public class HamkariContext : DbContext
    {
        public HamkariContext(DbContextOptions<HamkariContext> options):base(options)
        {


        }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationInstitute>().HasData(new List<EducationInstitute>
            {
                new EducationInstitute
                {
                    Name="SBU"
                },
                new EducationInstitute
                {
                    Name="PNU"
                }

            });
            //modelBuilder.Entity<Faculty>().HasData(new Faculty
            //{
            //    Name = "CSE",


            //});
            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role{Name="Admin"},new Role{Name="Student"},new Role{Name="teacher"},new Role{Name="Company"}
            });
            //modelBuilder.Entity<Student>().HasData(new Student
            //{
            //    Username = "RezaKlhor",
            //    Password = "324reza",
            //    Firstname = "Reza",
            //    Lastname = "Kalhori",
            //    gender = Gender.male,
            //    NationalIdNum = 3242115120,
            //    StudentID = 96243057,
            //    BirthDate = new DateTime(1999, 6, 10),
                

            //});
            //modelBuilder.Entity<Company>().HasData(new Company
            //{
            //    CompanyName = "مرکز رشد دانشکده کامپیوتر",
            //    CompanyIDnumber = 2222222222,
            //    Username = "CSEroshd",
            //    Password = "as6d4",
                

            //});
            //modelBuilder.Entity<Professor>().HasData(new Professor
            //{
            //    Username = "Dr.vahidi",
            //    Password = "51324342",
            //    Firstname = "Mojtaba",
            //    Lastname = "Vahidi",
            //    gender = Gender.male,
            //    NationalIdNum = 1535132133,
            //    PersonnelID = 235133212,
            //    BirthDate = new DateTime(1980, 1, 1)
            //});
            modelBuilder.Entity<WorkField>().HasData(new List<WorkField> { new WorkField{
                Name="AI",
            },new WorkField{Name="Software"},new WorkField{Name="Hardware"},new WorkField{Name="Network"}

            });
            //modelBuilder.Entity<>().HasData()
           
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<ProjectFile> ProjectFiles { get; set; }
        public DbSet<CoAnnouncement> CoAnnouncements { get; set; }
        public DbSet<CoApplication> CoApplications { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }
        public DbSet<EducationInstitute> EducationInstitutes { get; set; }
        public DbSet<EducationRecord> EducationRecords { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<ProjectManager> ProjectManagers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<TAapplication> TAapplications { get; set; }
        public DbSet<TArequest> TArequests { get; set; }
        public DbSet<WorkField> WorkFields { get; set; }
        public DbSet<Following> Followings { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}