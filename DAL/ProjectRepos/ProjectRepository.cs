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

        public Project GetProjectByName(string name)
        {
            return HamkariContext.Projects.SingleOrDefault(x => x.Name == name);
        }

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
            var projectParticipation = HamkariContext.ProjectParticapations.Where<ProjectParticapation>(m => m.User.id==userID).Include(m => m.Project).ToList();
            var projects = new List<Project>();
            foreach (var item in projectParticipation)
            {
                projects.Add(item.Project);
            }
            return projects;
        }

        public List<Project> GetProjectsByProjectState(ProjectState projectState)
        {
            return HamkariContext.Projects.Where(m => m.ProjectState == projectState).ToList();
        }

        public List<Project> GetProjectsByWorkField(Guid workFieldID)
        {
            var target = HamkariContext.ProjectWorkFields.Include(m=>m.Project).Where<ProjectWorkField>(m => m.WorkField.id == workFieldID).ToList();
            var projects = new List<Project>();
            foreach (var item in target)
            {
                projects.Add(item.Project);
            }
            return projects;
        }

        public List<Project> GetProjectsByWorkfields(List<Guid> workfields)
        {
            var projectLists = new List<List<Project>>();
            foreach (var item in workfields)
            {
                projectLists.Add(GetProjectsByWorkField(item));
            }
            return Tools<Project>.FindCommon(projectLists);

            
        }

        public List<Project> GetProjectsInSavedBox(Guid userID)
        {
            var Usersaves = HamkariContext.SavedProjects.Include(m => m.Project).Where(m => m.User.id == userID).ToList();
            var projects = new List<Project>();
            foreach (var item in Usersaves)
            {
                projects.Add(item.Project);
            }
            return projects;
        }
    }
}
