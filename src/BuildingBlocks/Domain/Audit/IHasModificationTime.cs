using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface IHasModificationTime
    {
        DateTime? LastModificationTime { get; set; }
    }
}