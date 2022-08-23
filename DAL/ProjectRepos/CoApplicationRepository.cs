using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.ProjectRepos
{
    public class CoApplicationRepository : Repository<CoApplication>, ICoApplicationRepository
    {
        public CoApplicationRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<CoApplication> GetCoApplicationsByAnnouncementWithApplicant(Guid annId)
        {
            return HamkariContext.CoApplications.Include(m => m.Applicant).Include(m => m.CoAnnouncement).Where(m => m.CoAnnouncement.id == annId).ToList();
        }
    }
}
