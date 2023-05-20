
using Core.DTOs;

namespace Core.Services
{
    public interface IWithdrawalService
    {
        public Task<List<WithdrawalDTOResponse>> GetAll();
    }
}
