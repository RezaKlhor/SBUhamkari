namespace DAL.UserRepos
{
    public interface ITArequestRepository : IRepository<TArequest>
    {
        List<TArequest> GetTArequestsByProfessor(Guid professorID);
        List<TArequest> GetTArequestsByProfessorWithTAapplications(Guid professorID);
        List<TArequest> GetAllWithProfessor();
        TArequest GetWithProfessor(Guid id);
    }
}
