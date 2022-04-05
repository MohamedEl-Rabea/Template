using System;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface IHasDeletionTime : ISoftDelete
    {
        DateTime? DeletionTime { get; set; }
    }
}