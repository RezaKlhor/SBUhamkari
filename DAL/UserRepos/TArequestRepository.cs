using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class TArequestRepository : Repository<TArequest>, ITArequestRepository
    {
        public TArequestRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<TArequest> GetAllWithProfessor()
        {
            return HamkariContext.TArequests.Include(m=> m.Professor).ToList();
        }

        public List<TArequest> GetTArequestsByProfessor(Guid professorID)
        {
            return Find(m => m.Professor.id == professorID).ToList();
        }

        public List<TArequest> GetTArequestsByProfessorWithTAapplications(Guid professorID)
        {
            return HamkariContext.TArequests.Where(m => m.Professor.id == professorID).Include(m => m.TAapplications).ToList();
        }

        public TArequest GetWithProfessor(Guid id)
        {
            return HamkariContext.TArequests.Include(m => m.Professor).Where(m => m.id == id).FirstOrDefault();
        }
    }
}
