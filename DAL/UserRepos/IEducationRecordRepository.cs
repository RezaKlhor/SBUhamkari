using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface IEducationRecordRepository : IRepository<EducationRecord>
    {
        List<EducationRecord> GetEducationRecordsByPerson(Guid personID);
        EducationRecord GetCurrentEducationRecord(Guid personID);
    }
}
