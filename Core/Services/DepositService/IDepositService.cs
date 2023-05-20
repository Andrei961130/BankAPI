
using Core.DTOs;

namespace Core.Services
{
    public interface IDepositService
    {
        public Task<List<DepositDTOResponse>> GetAll();
    }
}
