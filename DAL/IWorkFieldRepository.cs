namespace DAL
{
    public interface IWorkFieldRepository : IRepository<WorkField>
    {
        WorkField GetWorkFieldByName(string name);

    }
}
