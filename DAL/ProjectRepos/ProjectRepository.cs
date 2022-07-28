using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<Project> GetProjectsByManager(Guid projectManagerID)
        {
            var projectmanagers = HamkariContext.ProjectManagers.Where(m => m.User.id == projectManagerID);
            List<Project> projects = new List<Project>();
            foreach (var item in projectmanagers)
            {
                projects.Add(Get(item.Project.id));
            }
            return projects;
        }

        public List<Project> GetProjectsByManagerType(UserType userType)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsByParticipator(Guid userID)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsByProjectState(ProjectState projectState)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsByWorkfield(Guid workFieldID)
        {
            throw new NotImplementedException();
        }

        public List<Project> GetProjectsInSavedBox(Guid userID)
        {
            throw new NotImplementedException();
        }
    }
}
