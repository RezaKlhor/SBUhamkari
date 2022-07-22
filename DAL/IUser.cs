using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IUser : IRepository<User>
    {
        User GetUserWithProjects (Guid id);
        //User GetUserWithWorkFields (Guid id);
        //User GetUserWithSkills(Guid id);
        User GetUserWithContactInfo(Guid id);
        User GetUserWithFaculty(Guid id);
        //User GetUserWithEducationRecords(Guid id);
        User GetUserWithNews(Guid id);
        User GetUserWithFollowings(Guid id);
        User GetUserWithFollowers(Guid id);
        //User GetUserWithProjectsManages(Guid id);
        User GetUserWithNotifications(Guid id);
        User GetUserWithFeedbacks(Guid id);
        User GetUserWithSavedProjects(Guid id);

    }
}
