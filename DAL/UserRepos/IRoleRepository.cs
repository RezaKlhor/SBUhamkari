namespace DAL.UserRepos
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetRole(string role);
    }
}
