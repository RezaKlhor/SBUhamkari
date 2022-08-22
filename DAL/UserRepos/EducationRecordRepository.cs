using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class EducationRecordRepository : Repository<EducationRecord>, IEducationRecordRepository
    {
        public EducationRecordRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public EducationRecord GetCurrentEducationRecord(Guid personID)
        {
            return SingleOrDefault(m => m.EducationState == EducationState.Studying);
        }

        public EducationRecord GetEducationRecordByIdAndPersonId(Guid eduId, Guid personId)
        {
            return HamkariContext.EducationRecords.Where(m => m.id == eduId && m.Person.id == personId).FirstOrDefault();
        }

        public List<EducationRecord> GetEducationRecordsByPerson(Guid personID)
        {
            return Find(m => m.Person.id == personID).ToList();
        }
    }
}
