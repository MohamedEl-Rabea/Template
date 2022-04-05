namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface IModificationAudited : IHasModificationTime
    {
        string LastModifierUserId { get; set; }
    }
}