using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.UserRepos
{
    public class ContactInfoRepository : Repository<ContactInfo>, IContactInfoRepository
    {
        public ContactInfoRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<ContactInfo> GetContactInfosByUser(Guid userId, ContactInfoState contactInfoState)
        {
            return Find(m=>m.User.id==userId&&m.EntityState==contactInfoState).ToList();
        }
    }
}
