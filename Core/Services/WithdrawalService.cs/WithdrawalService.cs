
using Core.DTOs;
using Core.MapperConfig;
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

        public async Task<List<WithdrawalDTOResponse>> GetAll()
        {
            var operationTypes = WithdrawalRepository.GetAll();

            return await operationTypes.Select(to => to.ToDTO()).ToListAsync();
        }
    }
}
