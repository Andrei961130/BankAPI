using Core.Database;
using Core.Entities;    

namespace Core.Repositories
{
    public class DepositRepository : BaseRepository<Deposit>, IDepositRepository
    {
        public DepositRepository(DatabaseContext context) : base(context)
        {
        }

        public IQueryable<Deposit> GetAll()
        {
            return base.GetAll();
        }
    }
}
