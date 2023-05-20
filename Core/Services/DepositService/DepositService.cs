
using Core.DTOs;
using Core.Mappers;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class DepositService : IDepositService
    {
        public IDepositRepository depositRepository { get; set; }

        public DepositService(IDepositRepository depositRepository)
        {
            this.depositRepository = depositRepository;
        }

        public async Task<List<DepositDTOResponse>> GetAll()
        {
            var deposits = depositRepository.GetAll();

            return await deposits.Select(d => d.ToDTO()).ToListAsync();
        }
    }
}
