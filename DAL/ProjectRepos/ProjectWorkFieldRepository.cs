﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class ProjectWorkFieldRepository: Repository<ProjectWorkField>, IProjectWorkFieldRepository
    {
        public ProjectWorkFieldRepository(DbContext context) : base(context)
        {
        }

        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }
    }
}