using CompanyName.ProjectName.BuilidingBlocks.Domain.Time;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Values;
using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Events
{
    /// <summary>
    ///A Domain Event is an event that is spawned from the aggreagte root that is a result of a decision within the domain.
    ///</summary>
    public abstract class DomainEvent : IDomainEvent
    {
        public DateTime EventTime { get; set; }

        public object EventSource { get; set; }

        protected DomainEvent()
        {
            EventTime = CLock.Now;
        }
    }
}
