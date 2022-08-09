


using DAL.ProjectRepos;
using DAL.UserRepos;

namespace DAL
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        IUserReopsitory Users { get; }
        ITArequestRepository TArequests { get; }
        ITAapplicationRepository TAapplications { get; }
        IStudentRepository Students { get; }
        ISkillRepository Skills { get; }
        IWorkFieldRepository WorkFields { get; }
        IContactInfoRepository ContactInfos { get; }
        ICoAnnouncementRepository CoAnnouncements { get; }
        ICoApplicationRepository CoApplications { get; }
        INotificationRepository Notifications { get; }
        IProjectNewsRepository ProjectNews { get; }
        ICompanyRepository Companies { get; }
        IEducationRecordRepository EducationRecords { get; }
        IFacultyRepository FacultyRecords { get; }
        INewsRepository UserNews { get; }
        IPersonRepository People { get; }
        IProfessorRepository Professors { get; }
        ISavedProjectRepository SavedProjects { get; }
        IUserFollowerFollowingRepository UserFollowerFollowings { get; }
        IEducationInstitueRepository EducationInstitues { get; }
        IPersonWorkFieldRepository PersonWorkFields { get; }
        IProjectManagerRepository ProjectManagers { get; }
        IProjectParticapationRepository ProjectParticapations { get; }
        IProjectWorkFieldRepository ProjectWorkFields { get; }
        IRoleRepository Roles { get; }





        int Complete();
    }
}