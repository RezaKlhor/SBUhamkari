namespace DAL.UserRepos
{
    public interface ITAapplicationRepository : IRepository<TAapplication>
    {
        List<TAapplication> GetTAapplicationsByTArequestWithStudent(Guid tareqID);
        List<TAapplication> GetAapplicationsByStudentWithTArequest(Guid studentID);
    }
}
