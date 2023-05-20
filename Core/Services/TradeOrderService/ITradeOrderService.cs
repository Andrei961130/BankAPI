
using Core.DTOs;

namespace Core.Services
{
    public interface ITradeOrderService
    {
        public Task<List<TradeOrderDTOResponse>> GetAll();
    }
}
