global using Models.Models;
using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class UserRepository : Repository<User>, IUserReopsitory
    {
        public UserRepository(DbContext context) : base(context)
        {
            
        }


        private readonly IUnitOfWork _unitOfWork;
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

       

        public User GetUserByUsername(string username)
        {
            return HamkariContext.Users.Include(m=>m.Role).SingleOrDefault(m => m.Username == username);
        }

        public User GetUserByUsernameWithRole(string username)
        {
            return HamkariContext.Users.Include(m=>m.Role).SingleOrDefault(m => m.Username == username);
        }

        public List<User> GetUsersByProject(Guid projectId)
        {
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            var projectParticipations = unitOfWork.ProjectParticapations.GetProjectParticapationsByProjectWithUser(projectId);
            var users = projectParticipations.Select(m => m.User).ToList();
            return users;
        }

        public User GetUsersByIdWithRole(Guid id)
        {
            return HamkariContext.Users.Include(m => m.Role).Where(m => m.id == id).FirstOrDefault();
        }

        
        public List<User> GetAllUsersWithRole()
        {
            return HamkariContext.Users.Include(m => m.Role).ToList();
        }
    }
}
