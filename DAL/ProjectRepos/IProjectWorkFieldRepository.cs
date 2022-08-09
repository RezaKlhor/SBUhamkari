namespace DAL.ProjectRepos
{
    public interface IProjectWorkFieldRepository : IRepository<ProjectWorkField>
    {
        List<ProjectWorkField> GetProjectWorkFieldsByWorkFieldWithProject(Guid workFieldID);
    }
}
