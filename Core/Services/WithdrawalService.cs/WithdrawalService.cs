
using Core.DTOs;
using Core.ExtensionMethods;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class WithdrawalService : IWithdrawalService
    {
        public IWithdrawalRepository WithdrawalRepository { get; set; }

        public WithdrawalService(IWithdrawalRepository withdrawalRepository)
        {
            WithdrawalRepository = withdrawalRepository;
        }

        public async Task<(List<WithdrawalDTOResponse> withdrawals, int totalResults)> GetAll(PaginationRequest paginationRequest)
        {
            var query = WithdrawalRepository.GetAll();

            var totalResults = await query.CountAsync();

            var withdrawals = await query
                .Skip((paginationRequest.PageNumber - 1) * paginationRequest.PageSize).Take(paginationRequest.PageSize)
                .Select(to => to.ToDTO())
                .ToListAsync();

            return (withdrawals, totalResults);
        }
    }
}
