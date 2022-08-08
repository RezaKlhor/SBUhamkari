using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public List<EducationRecord> GetEducationRecordsByPerson(Guid personID)
        {
            return Find(m => m.Person.id == personID).ToList();
        }
    }
}
