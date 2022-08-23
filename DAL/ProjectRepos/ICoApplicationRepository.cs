namespace DAL.ProjectRepos
{
    public interface ICoApplicationRepository : IRepository<CoApplication>
    {
        List<CoApplication> GetCoApplicationsByAnnouncementWithApplicant(Guid id);
    }
}
