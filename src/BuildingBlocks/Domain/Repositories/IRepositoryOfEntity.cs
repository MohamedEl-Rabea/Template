using CompanyName.ProjectName.BuilidingBlocks.Domain.Entities;

namespace CompanyName.ProjectName.BuilidingBlocks.Domain.Repositories
{
    public interface IRepository<TEntity> : IRepository<TEntity, int> where TEntity : class, IEntity<int>
    {

    }
}

