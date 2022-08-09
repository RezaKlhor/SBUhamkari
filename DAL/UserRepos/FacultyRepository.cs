using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(DbContext context) : base(context)
        {
        }


        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }



        public Faculty GetFacultyByUserId(Guid userID)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var user = unitOfWork.Users.Get(userID);
            user.Faculty = new Faculty();
            return user.Faculty;
        }
    }
}
