using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Time
{
    public interface ISystmeCLock
    {
        public DateTime Now { get; }
    }
}
