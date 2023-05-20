
using Core.Entities;

namespace Core.Repositories
{
    public interface IWithdrawalRepository
    {
        public IQueryable<Withdrawal> GetAll();
    }
}
