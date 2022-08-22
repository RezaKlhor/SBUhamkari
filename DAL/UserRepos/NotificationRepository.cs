using Microsoft.EntityFrameworkCore;
using Models;

namespace DAL.UserRepos
{
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        public NotificationRepository(DbContext context) : base(context)
        {
        }
        public HamkariContext HamkariContext { get { return Context as HamkariContext; } }

        public List<Notification> GetNotificationsByReciever(Guid userID)
        {
            return HamkariContext.Notifications.Include(m=> m.Sender).Include(m=> m.Reciever).Where(m => m.Reciever.id == userID).ToList();
        }
    }
}
