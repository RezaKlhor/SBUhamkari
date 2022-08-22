using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class TAapplicationRepository : Repository<TAapplication>, ITAapplicationRepository
    {
        public TAapplicationRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<TAapplication> GetAapplicationsByStudentWithTArequest(Guid studentID)
        {
            return HamkariContext.TAapplications.Where(m => m.Student.id == studentID).Include(m => m.Tarequest).ToList();
        }

        public List<TAapplication> GetTAapplicationsByTArequestWithStudent(Guid tareqID)
        {
            return HamkariContext.TAapplications.Include(m=> m.Student).Where(m=> m.Tarequest.id==tareqID).ToList();
        }
    }
}
