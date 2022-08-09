namespace DAL.ProjectRepos
{
    public interface IProjectParticapationRepository : IRepository<ProjectParticapation>
    {
        List<ProjectParticapation> GetProjectParticapationsByUserWithProject(Guid userID);
    }
}
