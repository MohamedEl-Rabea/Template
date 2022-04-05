using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Events;
using Microsoft.EntityFrameworkCore;

namespace CompanyName.ProjectName.BuildingBlocks.Infrastructure.DomainEventsDispatching
{
    public class DomainEventsAccessor : IDomainEventsAccessor
    {
        private readonly DbContext _meetingsContext;

        public DomainEventsAccessor(DbContext meetingsContext)
        {
            _meetingsContext = meetingsContext;
        }

        public IReadOnlyCollection<IDomainEvent> GetAllDomainEvents()
        {
            var domainEntities = this._meetingsContext.ChangeTracker
                .Entries<IGeneratesDomainEvents>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any()).ToList();

            return domainEntities
                .SelectMany(x => x.Entity.DomainEvents)
                .ToList();
        }

        public void ClearAllDomainEvents()
        {
            var domainEntities = this._meetingsContext.ChangeTracker
                .Entries<IGeneratesDomainEvents>()
                .Where(x => x.Entity.DomainEvents != null && x.Entity.DomainEvents.Any()).ToList();

            domainEntities.ForEach(entity => entity.Entity.DomainEvents.Clear());
        }
    }
}