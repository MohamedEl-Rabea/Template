namespace CompanyName.ProjectName.BuildingBlocks.Infrastructure
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEventsAsync();
    }
}