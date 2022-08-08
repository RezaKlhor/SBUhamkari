using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface ITArequestRepository : IRepository<TArequest>
    {
        List<TArequest> GetTArequestsByProfessor(Guid professorID);
        List<TArequest> GetTArequestsByProfessorWithTAapplications(Guid professorID);
    }
}
