
using Azure.Core;
using Core.DTOs;
using Core.ExtensionMethods;
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

        public async Task<(List<TradeOrderDTOResponse> tradeOrders, int totalResults)> GetAll(PaginationRequest paginationRequest)
        {
            var query = TradeOrderRepository.GetAll();

            var totalResults = await query.CountAsync();

            var tradeOrders = await query
                .Skip((paginationRequest.PageNumber - 1) * paginationRequest.PageSize).Take(paginationRequest.PageSize)
                .Select(to => to.ToDTO())
                .ToListAsync();

            return (tradeOrders, totalResults);
        }
    }
}
