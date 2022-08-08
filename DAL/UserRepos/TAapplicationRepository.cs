﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public class TAapplicationRepository : Repository<TAapplication>, ITAapplicationRepository
    {
        public TAapplicationRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<TAapplication> GetAapplicationsByStudentWithTArequest(Guid studentID)
        {
            return HamkariContext.TAapplications.Where(m => m.Student.id == studentID).Include(m => m.Tarequest).ToList();
        }

        public List<TAapplication> GetTAapplicationsByTArequest(Guid tareqID)
        {
            return Find(m => m.Tarequest.id == tareqID).ToList();
        }
    }
}
