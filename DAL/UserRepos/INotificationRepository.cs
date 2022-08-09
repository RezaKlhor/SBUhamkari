namespace DAL.UserRepos
{
    public interface INotificationRepository : IRepository<Notification>
    {
        List<Notification> GetNotificationsByReciever(Guid userID);

    }
}
