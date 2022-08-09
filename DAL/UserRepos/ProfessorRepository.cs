using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class ProfessorRepository : Repository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
