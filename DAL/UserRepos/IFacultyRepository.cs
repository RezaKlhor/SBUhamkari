namespace DAL.UserRepos
{
    public interface IFacultyRepository : IRepository<Faculty>
    {

        Faculty GetFacultyByUserId(Guid userID);

    }
}
