using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface IProjectNewsRepository : IRepository<ProjectNews>
    {
        List<ProjectNews> GetProjectNewsByFollow(Guid userID);
        List<ProjectNews> GetProjectNewsByProject(Guid projectID);
        
    }
}
