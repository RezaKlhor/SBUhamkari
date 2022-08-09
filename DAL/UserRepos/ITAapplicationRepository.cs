namespace DAL.UserRepos
{
    public interface ITAapplicationRepository : IRepository<TAapplication>
    {
        List<TAapplication> GetTAapplicationsByTArequest(Guid tareqID);
        List<TAapplication> GetAapplicationsByStudentWithTArequest(Guid studentID);
    }
}
