using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL
{
    public class EducationInstitueRepository : Repository<EducationInstitute>, IEducationInstitueRepository
    {
        public EducationInstitueRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public EducationInstitute GetEducationInstituteByEducationRecord(Guid educationRecordID)
        {
            throw new NotImplementedException();
        }

        public EducationInstitute GetEducationInstituteByName(string name)
        {
            return SingleOrDefault(m => m.Name == name);
        }
    }
}
