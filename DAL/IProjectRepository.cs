using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IProjectRepository : IRepository<Project>
    {
        public List<Project> GetProjectsByWorkfield(Guid WorkFieldID);
        public List<Project> GetProjectsBy { get; set; }

    }
}
