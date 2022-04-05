namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Audit
{
    public interface ICreationAudited : IHasCreationTime
    {
        string CreatorUserId { get; set; }
    }
}