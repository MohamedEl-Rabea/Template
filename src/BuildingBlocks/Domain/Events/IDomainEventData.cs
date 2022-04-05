using System;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;
using MediatR;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Events
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }

        DateTime EventTime { get; set; }

        Entity EventSource { get; set; }
    }
}
