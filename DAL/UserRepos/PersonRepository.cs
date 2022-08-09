using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
