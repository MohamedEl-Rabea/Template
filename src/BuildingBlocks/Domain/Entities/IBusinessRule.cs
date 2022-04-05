using System.Threading.Tasks;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Entities
{
    public interface IBusinessRuleBase
    {
        string Message { get; }
    }

    public interface IBusinessRule : IBusinessRuleBase
    {
        bool IsBroken();
    }

    public interface IAsyncBusinessRule : IBusinessRuleBase
    {
        Task<bool> IsBrokenAsync();
    }
}
