using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class CoAnnouncementRepository : Repository<CoAnnouncement>, ICoAnnouncementRepository
    {
        public CoAnnouncementRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<CoAnnouncement> GetCoAnnouncementsByFollow(Guid userID)
        {
            var projectAnnouncements = new List<CoAnnouncement>();
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var followings = unitOfWork.UserFollowerFollowings.GetFollowingsByFollowerID(userID);
            foreach (var item in followings)
            {
                
                var projects = unitOfWork.Projects.GetProjectsByParticipator(item.FollowedID);
                foreach (var item2 in projects)
                {
                    projectAnnouncements.AddRange(unitOfWork.CoAnnouncements.GetCoAnnouncementsByProject(item2.id));
                }
            }
            unitOfWork.Dispose();
            return projectAnnouncements;
        }

        public List<CoAnnouncement> GetCoAnnouncementsByProject(Guid projectID)
        {
            return Find(m => m.Creator.Project.id == projectID).ToList();
        }

        public List<CoAnnouncement> GetCoAnnouncementsByWorkField(Guid WorkFieldID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var projects = unitOfWork.Projects.GetProjectsByWorkField(WorkFieldID);
            var CoAnnouncements= new List<CoAnnouncement>();
            foreach (var item in projects)
            {
                CoAnnouncements.AddRange(unitOfWork.CoAnnouncements.GetProjectsCoAnnouncement(item.id));
            }
            return CoAnnouncements;
        }

        public List<CoAnnouncement> GetProjectsCoAnnouncement(Guid ProjectID)
        {
            return Find(m => m.Creator.Project.id == ProjectID).ToList();
        }
    }
}
