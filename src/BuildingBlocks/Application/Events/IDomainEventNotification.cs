using MediatR;

namespace CompanyName.ProjectName.BuilidingBlocks.Application.Events
{
    public interface IDomainEventNotification<out TEventType> : IDomainEventNotification
    {
        TEventType DomainEvent { get; }
    }

    //TODO: Check if this base required
    public interface IDomainEventNotification : INotification
    {
        Guid Id { get; }
    }
}