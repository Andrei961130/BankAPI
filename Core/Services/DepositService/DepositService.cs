
using Core.DTOs;
using Core.ExtensionMethods;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class DepositService : IDepositService
    {
        public IDepositRepository DepositRepository { get; }

        public DepositService(IDepositRepository depositRepository)
        {
            DepositRepository = depositRepository;
        }

        public async Task<(List<DepositDTOResponse> deposits, int totalResults)> GetAll(PaginationRequest paginationRequest)
        {
            var query = DepositRepository.GetAll();

            var totalResults = await query.CountAsync();

            var deposits = await query
                .Skip((paginationRequest.PageNumber - 1) * paginationRequest.PageSize).Take(paginationRequest.PageSize)
                .Select(to => to.ToDTO())
                .ToListAsync();

            return (deposits, totalResults);
        }
    }
}
