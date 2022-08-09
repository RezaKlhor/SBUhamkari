namespace DAL.UserRepos
{
    public interface IRoleRepository : IRepository<Role>
    {
        Guid GetRoleID(string role);
    }
}
