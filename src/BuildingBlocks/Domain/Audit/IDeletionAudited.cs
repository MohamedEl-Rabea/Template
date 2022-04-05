namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface IDeletionAudited : IHasDeletionTime
    {
        string DeleterUserId { get; set; }
    }
}