namespace CompanyName.ProjectName.BuildingBlocks.Infrastructure
{
    public interface IDomainNotificationsMapper
    {
        string GetName(Type type);

        Type GetType(string name);
    }
}