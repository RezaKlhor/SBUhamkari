using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface IPersonWorkFieldRepository : IRepository<PersonWorkField>
    {
        List<PersonWorkField> GetPersonWorkFieldsByPersonWithWorkField(Guid personID);
        List<PersonWorkField> GetAllPersonWorkFieldsByWorkFieldWithPerson(Guid WorkFieldID);
    }
}
