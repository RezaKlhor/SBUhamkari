namespace DAL.UserRepos
{
    public interface ISavedProjectRepository : IRepository<SavedProject>
    {

        List<SavedProject> GetSavedProjectsByUserWithProject(Guid userID);
    }
}
