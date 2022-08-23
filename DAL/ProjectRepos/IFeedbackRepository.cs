using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public interface IFeedbackRepository : IRepository<Feedback>
    {
        List<Feedback> GetFeedbacksByProjectWithUser(Guid projectUser);
        List<Feedback> GetFeedbacksByUserWithProject(Guid userId);
        Feedback GetFeedbackByIdWithUserAndProject(Guid id);
    }
}
