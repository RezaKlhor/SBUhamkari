using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class PersonWorkFieldRepository : Repository<PersonWorkField>, IPersonWorkFieldRepository
    {
        public PersonWorkFieldRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public PersonWorkField GetAllPersonWorkFieldsByWorkFieldAndPerson(Guid personId, Guid workFieldID)
        {
            return GetPersonWorkFieldsByPersonWithWorkField(personId).Where(m => m.WorkField.id == workFieldID).FirstOrDefault();
        }

        public List<PersonWorkField> GetAllPersonWorkFieldsByWorkFieldWithPerson(Guid WorkFieldID)
        {
            return HamkariContext.PersonWorkFields.Where(m => m.WorkField.id == WorkFieldID).Include(m => m.Person).ToList();
        }

        public List<PersonWorkField> GetPersonWorkFieldsByPersonWithWorkField(Guid personID)
        {
            return HamkariContext.PersonWorkFields.Where(m => m.Person.id == personID).Include(m => m.WorkField).ToList();
        }
    }
}
