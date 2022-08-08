using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public class TArequestRepository : Repository<TArequest>, ITArequestRepository
    {
        public TArequestRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<TArequest> GetTArequestsByProfessor(Guid professorID)
        {
            return Find(m => m.Professor.id == professorID).ToList();
        }

        public List<TArequest> GetTArequestsByProfessorWithTAapplications(Guid professorID)
        {
            return HamkariContext.TArequests.Where(m => m.Professor.id == professorID).Include(m => m.TAapplications).ToList();
        }
    }
}
