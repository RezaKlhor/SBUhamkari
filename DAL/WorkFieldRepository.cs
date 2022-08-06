using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WorkFieldRepository : Repository<WorkField> ,IWorkFieldRepository
    {
        public WorkFieldRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public WorkField GetWorkFieldByName(string name)
        {
            return HamkariContext.WorkFields.SingleOrDefault(m => m.Name == name);
        }
    }
}
