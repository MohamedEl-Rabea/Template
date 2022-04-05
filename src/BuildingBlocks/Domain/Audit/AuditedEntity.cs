﻿using System;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public abstract class AuditedEntity : AuditedEntity<int>, IEntity
    {

    }


    public abstract class AuditedEntity<TPrimaryKey> : CreationAuditedEntity<TPrimaryKey>, IAudited
    {
        /// <summary>
        /// Last modification date of this entity.
        /// </summary>
        public virtual DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Last modifier user of this entity.
        /// </summary>
        public virtual string LastModifierUserId { get; set; }
    }
}
