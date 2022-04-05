using CompanyName.ProjectName.BuilidingBlocks.Domain.Events;

namespace CompanyName.ProjectName.BuildingBlocks.Infrastructure
{
    public interface IDomainEventsAccessor
    {
        IReadOnlyCollection<IDomainEvent> GetAllDomainEvents();

        void ClearAllDomainEvents();
    }
}