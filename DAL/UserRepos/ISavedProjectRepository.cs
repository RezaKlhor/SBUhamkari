using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface ISavedProjectRepository : IRepository<SavedProject>
    {

        List<SavedProject> GetSavedProjectsByUserWithProject(Guid userID);
    }
}
