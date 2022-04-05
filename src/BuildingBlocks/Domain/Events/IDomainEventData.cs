using System;
using MediatR;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Events
{
    public interface IDomainEvent : INotification
    {
        DateTime EventTime { get; set; }

        object EventSource { get; set; }
    }
}
