namespace DAL.UserRepos
{
    public interface IPersonWorkFieldRepository : IRepository<PersonWorkField>
    {
        List<PersonWorkField> GetPersonWorkFieldsByPersonWithWorkField(Guid personID);
        List<PersonWorkField> GetAllPersonWorkFieldsByWorkFieldWithPerson(Guid WorkFieldID);
        PersonWorkField GetAllPersonWorkFieldsByWorkFieldAndPerson(Guid personId, Guid workFieldID);
    }
}
