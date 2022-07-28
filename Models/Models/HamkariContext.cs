
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
            
            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role{Name="Admin"},new Role{Name="Student"},new Role{Name="Professor"},new Role{Name="Company"}
            });

            modelBuilder.Entity<Company>().HasIndex(m => m.CompanyIDnumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(m => m.Username).IsUnique();
            modelBuilder.Entity<Person>().HasIndex(m => m.NationalIdNum).IsUnique();
            


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