﻿using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.ProjectRepos
{
    public class CoAnnouncementRepository : Repository<CoAnnouncement>, ICoAnnouncementRepository
    {
        public CoAnnouncementRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }





        public List<CoAnnouncement> GetCoAnnouncementsByWorkField(Guid WorkFieldID)
        {
            //var projectsByWorkField =
            throw new NotImplementedException();
        }

        public List<CoAnnouncement> GetProjectsCoAnnouncement(Guid ProjectID)
        {
            throw new NotImplementedException();
        }
    }
}