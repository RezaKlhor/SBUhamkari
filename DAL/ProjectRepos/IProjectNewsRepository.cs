namespace DAL.ProjectRepos
{
    public interface IProjectNewsRepository : IRepository<ProjectNews>
    {
        List<ProjectNews> GetProjectNewsByFollow(Guid userID);
        List<ProjectNews> GetProjectNewsByProject(Guid projectID);

    }
}
