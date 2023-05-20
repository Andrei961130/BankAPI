
using Core.DTOs;
using Core.MapperConfig;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class TradeOrderService : ITradeOrderService
    {
        public ITradeOrderRepository TradeOrderRepository { get; set; }

        public TradeOrderService(ITradeOrderRepository tradeOrderRepository)
        {
            TradeOrderRepository = tradeOrderRepository;
        }

        public async Task<List<TradeOrderDTOResponse>> GetAll()
        {
            var operationTypes = TradeOrderRepository.GetAll();

            return await operationTypes.Select(to => to.ToDTO()).ToListAsync();
        }
    }
}
