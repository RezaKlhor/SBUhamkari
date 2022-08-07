namespace DAL.UserRepos
{
    public interface IUserFollowerFollowingRepository : IRepository<Following>
    {
        List<Following> GetFollowingsByFollowerID(Guid id);
    }
}