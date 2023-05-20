
using Core.Database;
using Core.Entities;

namespace Core.Repositories
{
    public class WithdrawalRepository : BaseRepository<Withdrawal>, IWithdrawalRepository
    {
        public WithdrawalRepository(DatabaseContext context) : base(context)
        {
        }

        public IQueryable<Withdrawal> GetAll()
        {
            return base.GetAll();
        }
    }
}
