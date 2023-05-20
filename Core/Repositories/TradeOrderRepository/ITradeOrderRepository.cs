
using Core.Entities;

namespace Core.Repositories
{
    public interface ITradeOrderRepository
    {
        public IQueryable<TradeOrder> GetAll();
    }
}
