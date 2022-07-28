using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface ICoAnnouncementRepository : IRepository<CoAnnouncement>
    {
        public List<CoAnnouncement> GetProjectsCoAnnouncement(Guid ProjectID);
        public List<CoAnnouncement> GetCoAnnouncementsByWorkField(Guid WorkFieldID);



    }
}
