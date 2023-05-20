
using Core.DTOs;

namespace Core.Services
{
    public interface IWithdrawalService
    {
        public Task<(List<WithdrawalDTOResponse> withdrawals, int totalResults)> GetAll(PaginationRequest paginationRequest);
    }
}
