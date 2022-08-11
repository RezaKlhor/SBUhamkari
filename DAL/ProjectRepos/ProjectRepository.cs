using Microsoft.EntityFrameworkCore;
using Models;

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

        public List<Project> GetProjectsByAll(List<Guid> workFieldsID, Guid ManagerRoleID, ProjectState projectState)
        {

            return (List<Project>)MakeNullIfEmpty( Tools<Project>.FindCommon(new List<List<Project>> {
                GetProjectsByWorkfields(workFieldsID),
                GetProjectsByManagerType(ManagerRoleID),
                GetProjectsByProjectState(projectState)

            }));
        }

        //Tested
        public List<Project> GetProjectsByManager(Guid projectManagerID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);

            var projectmanagers = unitOfWork.ProjectManagers.GetProjectManagersByManagerWithProject(projectManagerID);
            return (List<Project>)MakeNullIfEmpty(GetProjectsByManage(projectmanagers));
        }

        public List<Project> GetProjectsByManagerType(Guid roleID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var projectmanagers = unitOfWork.ProjectManagers.GetProjectManagersByManagerRoleWithProject(roleID);
            return (List<Project>)MakeNullIfEmpty(GetProjectsByManage(projectmanagers));
        }
        private List<Project> GetProjectsByManage(List<ProjectManager> projectManagers)
        {
            List<Project> projects = new List<Project>();
            foreach (var item in projectManagers)
            {
                projects.Add(item.Project);
            }
            return (List<Project>)MakeNullIfEmpty(projects);
        }
        public List<Project> GetProjectsByParticipator(Guid userID)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(HamkariContext))
            {

                var projectParticipation = unitOfWork.ProjectParticapations.GetProjectParticapationsByUserWithProject(userID);
                var projects = new List<Project>();
                foreach (var item in projectParticipation)
                {
                    projects.Add(item.Project);
                }
                return (List<Project>)MakeNullIfEmpty(projects);


            }
        }

        public List<Project> GetProjectsByProjectState(ProjectState projectState)
        {
            return HamkariContext.Projects.Where(m => m.ProjectState == projectState).ToList();
        }

        public List<Project> GetProjectsByWorkField(Guid workFieldID)
        {

            using (UnitOfWork unitOfWork = new UnitOfWork(HamkariContext))
            {
                var target = unitOfWork.ProjectWorkFields.GetProjectWorkFieldsByWorkFieldWithProject(workFieldID);
                var projects = new List<Project>();
                foreach (var item in target)
                {
                    projects.Add(item.Project);
                }
                return (List<Project>)MakeNullIfEmpty(projects);
            }

        }

        public List<Project> GetProjectsByWorkfields(List<Guid> workfields)
        {
            var projectLists = new List<List<Project>>();
            foreach (var item in workfields)
            {
                projectLists.Add(GetProjectsByWorkField(item));
            }
            return (List<Project>)MakeNullIfEmpty(Tools<Project>.FindCommon(projectLists));


        }

        public List<Project> GetProjectsInSavedBox(Guid userID)
        {
            using (UnitOfWork unitOfWork = new UnitOfWork(HamkariContext))
            {
                var Usersaves = unitOfWork.SavedProjects.GetSavedProjectsByUserWithProject(userID);
                var projects = new List<Project>();
                foreach (var item in Usersaves)
                {
                    projects.Add(item.Project);
                }
                return (List<Project>)MakeNullIfEmpty(projects);
            }
               
        }

    }
}
