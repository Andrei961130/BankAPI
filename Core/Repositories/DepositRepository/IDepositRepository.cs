
using Core.Entities;

namespace Core.Repositories
{
    public interface IDepositRepository
    {
        public IQueryable<Deposit> GetAll();
    }
}
