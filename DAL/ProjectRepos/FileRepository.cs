using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class FileRepository : Repository<ProjectFile>, IFileRepository
    {
        public FileRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
        public List<ProjectFile> GetProjectFilesByProject(Guid projectId)
        {
            return HamkariContext.ProjectFiles.Include(m => m.Project).Where(m => m.Project.id == projectId).ToList();
        }
    }
}
