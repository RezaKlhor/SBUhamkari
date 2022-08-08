using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public class SavedProjectRepository : Repository<SavedProject>, ISavedProjectRepository
    {
        public SavedProjectRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<SavedProject> GetSavedProjectsByUserWithProject(Guid userID)
        {
            return HamkariContext.SavedProjects.Where(m => m.User.id == userID).Include(m => m.Project).ToList();
        }
    }
}
