namespace DAL.ProjectRepos
{
    public interface IProjectManagerRepository : IRepository<ProjectManager>
    {
        List<ProjectManager> GetProjectManagersByManagerWithProject(Guid managerID);
        List<ProjectManager> GetProjectManagersByManagerRoleWithProject(Guid roleID);
        //ProjectManager GetProjectManagerByUserAndProject(Guid userId, Guid projectId);

    }
}
