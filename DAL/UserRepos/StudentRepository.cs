using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class StudentRepository : Repository<Student>, IStudentRepository
    {
        public StudentRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
