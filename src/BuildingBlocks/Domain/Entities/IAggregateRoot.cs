using System.Collections.Generic;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Events;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Entities
{
    public interface IAggregateRoot : IAggregateRoot<int>, IEntity
    {

    }

    public interface IAggregateRoot<TPrimaryKey> : IEntity<TPrimaryKey>, IGeneratesDomainEvents
    {

    }

    public interface IGeneratesDomainEvents
    {
        ICollection<IDomainEvent> DomainEvents { get; }
    }
}