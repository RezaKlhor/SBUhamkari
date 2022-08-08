﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface IFacultyRepository : IRepository<Faculty>
    {
        
        Faculty GetFacultyByUserId(Guid userID);

    }
}
