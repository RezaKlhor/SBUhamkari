namespace DAL.UserRepos
{
    public interface IUserReopsitory : IRepository<User>
    {
        User GetUserByUsername(string username);
        User GetUserByUsernameWithRole(string username);

        void AddUserInit();


    }
}
