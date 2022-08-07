using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface ICoAnnouncementRepository : IRepository<CoAnnouncement>
    {
        List<CoAnnouncement> GetProjectsCoAnnouncement(Guid ProjectID);
        List<CoAnnouncement> GetCoAnnouncementsByWorkField(Guid WorkFieldID);
        List<CoAnnouncement> GetCoAnnouncementsByFollow(Guid userID);
        List<CoAnnouncement> GetCoAnnouncementsByProject(Guid projectID);




    }
}
