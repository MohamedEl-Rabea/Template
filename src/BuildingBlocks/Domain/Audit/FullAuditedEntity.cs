using System;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public abstract class FullAuditedEntity : FullAuditedEntity<int>, IEntity
    {

    }

    public abstract class FullAuditedEntity<TPrimaryKey> : AuditedEntity<TPrimaryKey>, IFullAudited
    {
        public virtual bool IsDeleted { get; set; }

        public virtual string DeleterUserId { get; set; }

        public virtual DateTime? DeletionTime { get; set; }
    }
}
