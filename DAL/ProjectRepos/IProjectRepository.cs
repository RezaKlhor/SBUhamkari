using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface IProjectRepository : IRepository<Project>
    {
        public List<Project> GetProjectsByWorkfield(Guid workFieldID);
        public List<Project> GetProjectsByParticipator(Guid userID);
        public List<Project> GetProjectsByManager(Guid projectManagerID);
        public List<Project> GetProjectsByProjectState(ProjectState projectState);
        public List<Project> GetProjectsInSavedBox(Guid userID);
        public List<Project> GetProjectsByManagerType(UserType userType);
       

    }
    public enum UserType { Teacher,Student,Company}
}
