using DTO.ProjectDtos;

namespace DAL.ProjectRepos
{
    public interface IProjectRepository : IRepository<Project>
    {

        List<Project> GetProjectsByWorkField(Guid workFieldID);
        List<Project> GetProjectsByWorkfields(List<Guid> workFieldID);
        List<Project> GetProjectsByParticipator(Guid userID);
        List<Project> GetProjectsByManager(Guid projectManagerID);
        List<Project> GetProjectsByProjectState(ProjectState projectState);
        List<Project> GetProjectsInSavedBox(Guid userID);
        List<Project> GetProjectsByManagerType(Guid roleID);
        List<Project> GetProjectsByAll(List<Guid> workFieldsID, string ManagerRole, ProjectStateFilter projectState);
        Project GetProjectByName(string name);
        List<CoAnnouncement> GetCoAnnouncementsByFolloweId(Guid followerId);
        List<ProjectNews> GetProjectNewsByFolloweId(Guid followerId);



    }

}
