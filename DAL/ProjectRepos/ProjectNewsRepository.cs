﻿using Microsoft.EntityFrameworkCore;
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
            var projectNews = new List<ProjectNews>();
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var followings = unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userID);
            foreach (var item in followings)
            {

                var projects = unitOfWork.Projects.GetProjectsByParticipator(item.FollowedID);
                foreach (var item2 in projects)
                {
                    projectNews.AddRange(unitOfWork.ProjectNews.GetProjectNewsByProject(item2.id));
                }
            }
            unitOfWork.Dispose();
            return projectNews;
        }

        public List<ProjectNews> GetProjectNewsByProject(Guid projectID)
        {
            return HamkariContext.ProjectNews.Where(m => m.Project.id == projectID).ToList();
        }
    }
}
