namespace DAL.UserRepos
{
    public interface IEducationRecordRepository : IRepository<EducationRecord>
    {
        List<EducationRecord> GetEducationRecordsByPerson(Guid personID);
        EducationRecord GetCurrentEducationRecord(Guid personID);
        EducationRecord GetEducationRecordByIdAndPersonId(Guid eduId, Guid personId);
    }
}
