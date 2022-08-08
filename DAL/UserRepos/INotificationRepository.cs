﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface INotificationRepository : IRepository<Notification>
    {
        List<Notification> GetNotificationsByReciever(Guid userID);
        
    }
}
