using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface IHasCreationTime
    {
        DateTime CreationTime { get; set; }
    }
}