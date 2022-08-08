using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface ITAapplicationRepository : IRepository<TAapplication>
    {
        List<TAapplication> GetTAapplicationsByTArequest(Guid tareqID);
        List<TAapplication> GetAapplicationsByStudentWithTArequest(Guid studentID);
    }
}
