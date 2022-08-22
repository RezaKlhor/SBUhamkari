using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{
    public class ProjectNewsRepository : Repository<ProjectNews>, IProjectNewsRepository
    {
        public ProjectNewsRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<ProjectNews> GetProjectNewsByFollow(Guid userID)
        {
            using(UnitOfWork unitOfWork = new UnitOfWork(HamkariContext))
            {
                var projectNews = new List<ProjectNews>();
                var followings = unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userID);
                foreach (var item in followings)
                {

                    var projects = unitOfWork.Projects.GetProjectsByParticipator(item.FollowedID);
                    foreach (var item2 in projects)
                    {
                        projectNews.AddRange(unitOfWork.ProjectNews.GetProjectNewsByProject(item2.id));
                    }
                }
                return projectNews;
            }
            
        }

        public List<ProjectNews> GetProjectNewsByProject(Guid projectID)
        {
            return HamkariContext.ProjectNews.Where(m => m.Project.id == projectID).ToList();
        }

        public ProjectNews GetProjectNewsWithProject(Guid id)
        {
            return HamkariContext.ProjectNews.Include(m => m.Project).Where(m => m.id == id).FirstOrDefault();
        }
    }
}
