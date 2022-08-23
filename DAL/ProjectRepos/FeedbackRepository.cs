using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class FeedbackRepository : Repository<Feedback>, IFeedbackRepository
    {

        public FeedbackRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public Feedback GetFeedbackByIdWithUserAndProject(Guid id)
        {
            return HamkariContext.Feedbacks.Include(m => m.User).Include(m => m.Project).Where(m => m.id == id).FirstOrDefault();
        }

        public List<Feedback> GetFeedbacksByProjectWithUser(Guid projectId)
        {
            return HamkariContext.Feedbacks.Include(m => m.User).Include(m => m.Project).Where(m => m.Project.id == projectId).ToList();
        }

        public List<Feedback> GetFeedbacksByUserWithProject(Guid userId)
        {
            return HamkariContext.Feedbacks.Include(m => m.User).Include(m => m.Project).Where(m => m.User.id == userId).ToList();
        }
        
    }
}
