﻿using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public interface IUserReopsitory : IRepository<User>
    {
        User GetUserByUsername(string username);


    }
}
