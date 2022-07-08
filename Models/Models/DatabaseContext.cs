
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options):base(options)
        {


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
    }
}