
using Core.Database;
using Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Core.Repositories
{
    public class TradeOrderRepository : BaseRepository<TradeOrder>, ITradeOrderRepository
    {
        public TradeOrderRepository(DatabaseContext context) : base(context)
        {
        }

        public IQueryable<TradeOrder> GetAll()
        {
            return base.GetAll()
                .Include(to => to.TradeOrderType);
        }
    }
}
