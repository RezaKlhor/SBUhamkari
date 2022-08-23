namespace DAL.ProjectRepos
{
    public interface ICoAnnouncementRepository : IRepository<CoAnnouncement>
    {
        List<CoAnnouncement> GetProjectsCoAnnouncement(Guid ProjectID);
        List<CoAnnouncement> GetCoAnnouncementsByWorkField(Guid WorkFieldID);
        List<CoAnnouncement> GetCoAnnouncementsByFollow(Guid userID);
        List<CoAnnouncement> GetCoAnnouncementsByProject(Guid projectID);
        CoAnnouncement GetCoAnnouncementByIdWithProjManager(Guid id);




    }
}
