namespace DAL
{
    public interface IEducationInstitueRepository : IRepository<EducationInstitute>
    {
        EducationInstitute GetEducationInstituteByName(string name);
        EducationInstitute GetEducationInstituteByEducationRecord(Guid educationRecord);
    }
}
