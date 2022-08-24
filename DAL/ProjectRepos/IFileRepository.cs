using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface IFileRepository : IRepository<ProjectFile>
    {
        List<ProjectFile> GetProjectFilesByProject(Guid projectId);
    }
}
