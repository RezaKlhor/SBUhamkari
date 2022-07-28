using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.User
{
    public class PersonWorkFieldRepository : Repository<PersonWorkField>, IPersonWorkFieldRepository
    {
        public PersonWorkFieldRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
