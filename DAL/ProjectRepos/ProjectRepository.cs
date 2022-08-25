using DTO.ProjectDtos;
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

        public List<Project> GetProjectByName(string name)
        {
            return HamkariContext.Projects.Where(m=> m.Name==name).ToList();
        }

        public List<Project> GetProjectsByAll(List<Guid> workFieldsID, string ManagerRole
            , ProjectStateFilter projectState)
        {
            var byWorkFields = new List<Project>();
            var byManagerRole= new List<Project>();
            var byProjectState = new List<Project>();
            if (workFieldsID.Count==0)
            {
                byWorkFields = HamkariContext.Projects.ToList();
            }
            else
            {
                byWorkFields = GetProjectsByWorkfields(workFieldsID);
            }

            if (ManagerRole.ToString().Length == 0)
            {
                byManagerRole = HamkariContext.Projects.ToList();
            }
            else
            {
                byManagerRole = GetProjectsByManagerType(HamkariContext.Roles.Where(m=> m.Name==ManagerRole).FirstOrDefault().id);
            }

            if (projectState == ProjectStateFilter.DONTCARE)
            {
                byProjectState = HamkariContext.Projects.ToList();
            }
            else
            {
                if (projectState==ProjectStateFilter.Ongoing)
                {
                byProjectState = GetProjectsByProjectState(ProjectState.Ongoing);

                }
                else
                {
                    byProjectState = GetProjectsByProjectState(ProjectState.Ended);
                }
            }



            var projects=Tools<Project>.FindCommon(new List<List<Project>> {
                byWorkFields,
               byManagerRole,
                byProjectState

            });
            if (projects==null)
            {
                return null;
            }
            return  projects;
        }

        //Tested
        public List<Project> GetProjectsByManager(Guid projectManagerID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);

            var projectmanagers = unitOfWork.ProjectManagers.GetProjectManagersByManagerWithProject(projectManagerID);
            var projects= GetProjectsByManage(projectmanagers);
            
            return projects;
        }

        public List<Project> GetProjectsByManagerType(Guid roleID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var projectmanagers = unitOfWork.ProjectManagers.GetProjectManagersByManagerRoleWithProject(roleID);
            var projects = GetProjectsByManage(projectmanagers);
            
            return projects;
        }
        private List<Project> GetProjectsByManage(List<ProjectManager> projectManagers)
        {
            List<Project> projects = new List<Project>();
            foreach (var item in projectManagers)
            {
                projects.Add(item.Project);
            }
            if (projects.Count == 0)
            {
                return null;
            }
            return projects;
        }
        public List<Project> GetProjectsByParticipator(Guid userID)
        {

            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
                var projectParticipation = unitOfWork.ProjectParticapations.GetProjectParticapationsByUserWithProject(userID);
                var projects = new List<Project>();
                foreach (var item in projectParticipation)
                {
                    projects.Add(item.Project);
                }
                if (projects.Count == 0)
                {
                    return null;
                }
                return projects;


            
        }

        public List<Project> GetProjectsByProjectState(ProjectState projectState)
        {
            var projects= HamkariContext.Projects.Where(m => m.ProjectState == projectState).ToList();
            if (projects.Count == 0)
            {
                return null;
            }
            return projects;
        }

        public List<Project> GetProjectsByWorkField(Guid workFieldID)
        {

            
                
                var target = GetProjectWorkFieldsByWorkFieldWithProject(workFieldID);
                var projects = new List<Project>();
                foreach (var item in target)
                {
                    projects.Add(item.Project);
                }
                if (projects.Count == 0)
                {
                    return null;
                }
                return projects;
            

        }
        private List<ProjectWorkField> GetProjectWorkFieldsByWorkFieldWithProject(Guid workFieldID)
        {

            return HamkariContext.ProjectWorkFields.Include(m => m.Project).Include(m => m.WorkField).Where<ProjectWorkField>(m => m.WorkField.id == workFieldID).ToList();
        }
        public List<Project> GetProjectsByWorkfields(List<Guid> workfields)
        {
            var projectLists = new List<List<Project>>();
            foreach (var item in workfields)
            {
                var temp = GetProjectsByWorkField(item);
                if (temp!=null)
                {
                    projectLists.Add(GetProjectsByWorkField(item));
                }
               
            }
            
            var projects= Tools<Project>.FindCommon(projectLists);
            return projects;


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
                if (projects.Count == 0)
                {
                    return null;
                }
                return projects;
            }
               
        }

       

        public List<ProjectNews> GetProjectNewsByFolloweId(Guid followerId)
        {
            throw new NotImplementedException();
        }

        public List<CoAnnouncement> GetCoAnnouncementsByFolloweId(Guid followerId)
        {
            throw new NotImplementedException();
        }
    }
}
