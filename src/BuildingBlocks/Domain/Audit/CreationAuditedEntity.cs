using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Time;
using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public abstract class CreationAuditedEntity : CreationAuditedEntity<int>, IEntity
    {

    }

    public abstract class CreationAuditedEntity<TPrimaryKey> : Entity<TPrimaryKey>, ICreationAudited
    {
        public virtual DateTime CreationTime { get; set; }

        public virtual string CreatorUserId { get; set; }

        protected CreationAuditedEntity()
        {
            //TODO: Should be moved to SaveChanges() in DbContext
            CreationTime = CLock.Now;
        }
    }
}