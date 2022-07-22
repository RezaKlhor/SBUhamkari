﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFacultyRepository: IRepository<Faculty>
    {
        List<Faculty> GetFacultiesinInstitue(Guid id);

    }
}
