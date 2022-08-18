namespace DAL.UserRepos
{
    public interface IUserReopsitory : IRepository<User>
    {
        User GetUserByUsername(string username);
        User GetUserByUsernameWithRole(string username);
        List<User> GetUsersByProject(Guid projectId);
        User GetUsersByIdWithRole(Guid Id);
        


    }
}
