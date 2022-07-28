using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.User
{
    public class FacultyRepository : Repository<Faculty>, IFacultyRepository
    {
        public FacultyRepository(DbContext context) : base(context)
        {
        }

        public List<Faculty> GetFacultiesinInstitue(Guid id)
        {
            return Find(a => a.EducationInstitute.id == id).ToList();

        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}
