namespace DAL.UserRepos
{
    public interface ISkillRepository : IRepository<Skill>
    {
        List<Skill> GetSkillsByPerson(Guid personID);
        List<Skill> GetSkillsByTittle(string tittle);
    }
}
