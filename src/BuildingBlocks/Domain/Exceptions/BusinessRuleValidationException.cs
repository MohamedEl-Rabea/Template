using CompanyName.ProjectName.BuildingBlocks.Common;
using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Exceptions
{
    public class BusinessRuleValidationException : ApplicationExceptionBase
    {
        public IBusinessRuleBase BrokenRule { get; }

        public string Details { get; }

        public BusinessRuleValidationException(IBusinessRuleBase brokenRule)
              : base(brokenRule.Message)
        {
            BrokenRule = brokenRule;
            Details = brokenRule.Message;
        }

        public override string ToString()
        {
            return $"{BrokenRule.GetType().FullName}: {BrokenRule.Message}";
        }
    }
}
