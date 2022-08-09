using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            UnitOfWork unitOfWork = new UnitOfWork(HamkariContext);
            return unitOfWork.EducationRecords.Get(educationRecordID).EducationInstitute;
        }

        public EducationInstitute GetEducationInstituteByName(string name)
        {
            return SingleOrDefault(m => m.Name == name);
        }
    }
}
