
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace Models
{
    public class HamkariContext : DbContext
    {
        public HamkariContext(DbContextOptions<HamkariContext> options) : base(options)
        {


        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EducationInstitute>().HasData(new List<EducationInstitute>
            {
                new EducationInstitute
                {
                    Name="دانشگاه شهید بهشتی"
                },
                new EducationInstitute
                {
                    Name="دانشگاه تهران"
                },
                new EducationInstitute
                {
                    Name="دانشگاه صنعتی امیرکبیر"
                },
                new EducationInstitute
                {
                    Name="دانشگاه علم و صنعت"
                },
                new EducationInstitute
                {
                    Name="دانشگاه صنعتی صنعتی شریف"
                },
            });
            modelBuilder.Entity<Faculty>().HasData(new List<Faculty> {
                new Faculty{Name="دانشکده برق و کامپیوتر"},
                new Faculty{Name="دانشکده حقوق"},
                new Faculty{Name="دانشکده رواشناسی و علوم تربیتی"},
                new Faculty{Name="دانشکده معماری"},
                new Faculty{Name="دانشکده علوم پایه"},



            });
            modelBuilder.Entity<Role>().HasData(new List<Role>
            {
                new Role{Name="Admin"},new Role{Name="Student"},new Role{Name="Professor"},new Role{Name="Company"}
            });
            modelBuilder.Entity<WorkField>().HasData(new List<WorkField> {
                new WorkField{Name="هوش مصنوعی"},
                new WorkField{Name="نرم افزار"},
                new WorkField{Name="سخت افزار"},
                new WorkField{Name="علوم داده"},
                new WorkField{Name="شبکه"},
                new WorkField{Name="هوش مصنوعی"},
                new WorkField{Name="شبکه‌های پیچیده"},
                new WorkField{Name="فناوری اطلاعات"},
            });


            modelBuilder.Entity<Company>().HasIndex(m => m.CompanyIDnumber).IsUnique();
            modelBuilder.Entity<User>().HasIndex(m => m.Username).IsUnique();
            modelBuilder.Entity<Person>().HasIndex(m => m.NationalIdNum).IsUnique();
            modelBuilder.Entity<User>().HasMany<ParticipationInvitation>(m => m.ParticipationInvitations).WithOne(m => m.InvitedUser).OnDelete(DeleteBehavior.NoAction);


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
        public DbSet<ProjectParticapation> ProjectParticapations { get; set; }
        public DbSet<ProjectWorkField> ProjectWorkFields { get; set; }
        public DbSet<PersonWorkField> PersonWorkFields { get; set; }
        public DbSet<ProjectNews> ProjectNews { get; set; }
        public DbSet<ParticipationInvitation> ParticipationInvitations { get; set; }
        public DbSet<SavedProject> SavedProjects { get; set; }

    }
}