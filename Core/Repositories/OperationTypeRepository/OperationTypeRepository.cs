

using Core.Database;
using Core.Entities;

namespace Core.Repositories
{
    public class OperationTypeRepository : BaseRepository<OperationType>, IOperationTypeRepository
    {
        public OperationTypeRepository(DatabaseContext context) : base(context)
        {
        }

        public IQueryable<OperationType> GetAll()
        {
            return base.GetAll();
        }
    }
}
