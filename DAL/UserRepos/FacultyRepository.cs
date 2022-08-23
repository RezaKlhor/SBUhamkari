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
            
            return HamkariContext.Faculties.Where(m=> m.id==HamkariContext.Users.Include(m=> m.Faculty).Where(m=> m.id==userID).FirstOrDefault().id).FirstOrDefault();
        }
    }
}
