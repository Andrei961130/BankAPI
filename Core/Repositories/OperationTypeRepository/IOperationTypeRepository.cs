
using Core.Entities;

namespace Core.Repositories
{
    public interface IOperationTypeRepository
    {
        public IQueryable<OperationType> GetAll();
    }
}
