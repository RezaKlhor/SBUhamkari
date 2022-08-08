using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface ISkillRepository : IRepository<Skill>
    {
        List<Skill> GetSkillsByPerson(Guid personID);
        List<Skill> GetSkillsByTittle(string tittle);
    }
}
