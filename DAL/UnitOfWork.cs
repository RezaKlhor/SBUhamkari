
using DAL.ProjectRepos;
using DAL.UserRepos;
using Models;

namespace DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly HamkariContext _context;

       
        public UnitOfWork(HamkariContext context)
        {
            _context = context;
            Projects = new ProjectRepository(_context);
            Users= new UserRepository(_context);
            TArequests= new TArequestRepository(_context);
            TAapplications = new TAapplicationRepository(_context);
            Students= new StudentRepository(_context);
            Skills = new SkillRepository(_context);
            WorkFields = new WorkFieldRepository(_context);
            ContactInfos= new ContactInfoRepository(_context);
            CoAnnouncements = new CoAnnouncementRepository(_context);
            CoApplications= new CoApplicationRepository(_context);
            Notifications = new NotificationRepository(_context);
            ProjectNews= new ProjectNewsRepository(_context);
            Companies = new CompanyRepository(_context);
            EducationRecords = new EducationRecordRepository(_context);
            FacultyRecords = new FacultyRepository(_context);
            UserNews = new NewsRepository(_context);
            People = new PersonRepository(_context);
            Professors = new ProfessorRepository(_context);
            SavedProjects = new SavedProjectRepository(_context);
            UserFollowerFollowings = new UserFollowerFollowingRepository(_context);
            EducationInstitues = new EducationInstitueRepository(_context);
            PersonWorkFields = new PersonWorkFieldRepository(_context);
            ProjectManagers = new ProjectManagerRepository(_context);
            ProjectParticapations = new ProjectParticapationRepository(_context);
            ProjectWorkFields = new ProjectWorkFieldRepository(_context);

            
        }

        public IProjectRepository Projects { get; private set; }

        public IUserReopsitory Users { get; private set; }

        public ITArequestRepository TArequests { get; private set; }

        public ITAapplicationRepository TAapplications { get; private set; }

        public IStudentRepository Students { get; private set; }

        public ISkillRepository Skills { get; private set; }

        public IWorkFieldRepository WorkFields { get; private set; }

        public IContactInfoRepository ContactInfos { get; private set; }

        public ICoAnnouncementRepository CoAnnouncements { get; private set; }

        public ICoApplicationRepository CoApplications { get; private set; }

        public INotificationRepository Notifications { get; private set; }
        public IProjectNewsRepository ProjectNews { get; private set; }

        public ICompanyRepository Companies { get; private set; }

        public IEducationRecordRepository EducationRecords { get; private set; }

        public IFacultyRepository FacultyRecords { get; private set; }
        public INewsRepository UserNews { get; private set; }

        public IPersonRepository People { get; private set; }

        public IProfessorRepository Professors { get; private set; }

        public ISavedProjectRepository SavedProjects { get; private set; }

        public IUserFollowerFollowingRepository UserFollowerFollowings { get; private set; }

        public IEducationInstitueRepository EducationInstitues { get; private set; }
        public IPersonWorkFieldRepository PersonWorkFields { get; private set; }

        public IProjectManagerRepository ProjectManagers { get; private set; }

        public IProjectParticapationRepository ProjectParticapations { get; private set; }

        public IProjectWorkFieldRepository ProjectWorkFields { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}