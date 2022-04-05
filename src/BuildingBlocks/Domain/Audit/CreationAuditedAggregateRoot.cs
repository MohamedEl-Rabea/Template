using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Time;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Values;
using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public abstract class CreationAuditedAggregateRoot : CreationAuditedAggregateRoot<int>
    {

    }
    public abstract class CreationAuditedAggregateRoot<TPrimaryKey> : AggregateRoot<TPrimaryKey>, ICreationAudited
    {
        public DateTime CreationTime { get; set; }
        public string CreatorUserId { get; set; }

        protected CreationAuditedAggregateRoot()
        {
            //TODO: Should be removed from here and moved to SaveChanges() in DbContext
            CreationTime = CLock.Now;
        }
    }
}
