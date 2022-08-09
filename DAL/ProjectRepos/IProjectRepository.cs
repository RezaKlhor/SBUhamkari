using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        List<Project> GetProjectsByAll(List<Guid> workFieldsID, Guid ManagerRoleID, ProjectState projectState);
        Project GetProjectByName(string name);

       

    }
    
}
