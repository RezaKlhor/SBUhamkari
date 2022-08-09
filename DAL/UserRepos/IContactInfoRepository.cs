namespace DAL.UserRepos
{
    public interface IContactInfoRepository : IRepository<ContactInfo>
    {
        List<ContactInfo> GetContactInfosByUser(Guid userId, ContactInfoState contactInfoState);


    }
}