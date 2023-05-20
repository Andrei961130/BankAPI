
using Core.DTOs;

namespace Core.Services
{
    public interface IDepositService
    {
        public Task<(List<DepositDTOResponse> deposits, int totalResults)> GetAll(PaginationRequest paginationRequest);
    }
}
