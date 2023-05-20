
using Core.DTOs;
using Core.MapperConfig;
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

        public async Task<List<DepositDTOResponse>> GetAll()
        {
            var deposits = DepositRepository.GetAll();

            return await deposits.Select(d => d.ToDTO()).ToListAsync();
        }
    }
}
