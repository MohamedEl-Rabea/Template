using System.Linq.Expressions;

namespace CompanyName.ProjectName.BuilidingBlocks.Application.Wrappers
{
    public interface IFilter<T>
    {
        Expression<Func<T, bool>> ToExpression();
    }
}
