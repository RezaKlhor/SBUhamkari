namespace DAL.UserRepos
{
    public interface IUserReopsitory : IRepository<User>
    {
        User GetUserByUsername(string username);
        void AddUserInit();


    }
}
