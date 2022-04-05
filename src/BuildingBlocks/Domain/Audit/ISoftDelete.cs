namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}