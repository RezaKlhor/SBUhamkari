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

        //Tested
        public List<Project> GetProjectsByManager(Guid projectManagerID)
        {
            var projectmanagers = HamkariContext.ProjectManagers.Where<ProjectManager>(m => m.id== projectManagerID).Include(m=> m.Project).ToList();
            List<Project> projects = new List<Project>();
            foreach (var item in projectmanagers)
            {
                projects.Add(item.Project);
            }
            return projects;
        }

        public List<Project> GetProjectsByManagerType(Guid RoleID)
        {
            var projectmanagers = HamkariContext.ProjectManagers.Where<ProjectManager>
                (m => m.User.Role.id==RoleID).Include(m => m.Project).ToList();
            List<Project> projects = new List<Project>();
            foreach (var item in projectmanagers)
            {
                projects.Add(item.Project);
            }
            return projects;
        }

        public List<Project> GetProjectsByParticipator(Guid userID)
        {
            var projectParticipation = HamkariContext.ProjectParticapations.Where<ProjectParticapation>(m => m.id==userID).Include(m => m.Project).ToList();
            var projects = new List<Project>();
            foreach (var item in projectParticipation)
            {
                projects.Add(item.Project);
            }
            return projects;
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
