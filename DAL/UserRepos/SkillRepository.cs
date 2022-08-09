using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class SkillRepository : Repository<Skill>, ISkillRepository
    {
        public SkillRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<Skill> GetSkillsByPerson(Guid personID)
        {
            return Find(m => m.Person.id == personID).ToList();
        }

        public List<Skill> GetSkillsByTittle(string tittle)
        {
            return Find(m => m.SkillTitle == tittle).ToList();
        }
    }
}
