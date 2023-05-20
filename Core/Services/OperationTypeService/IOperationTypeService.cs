
using Core.DTOs;

namespace Core.Services
{
    public interface IOperationTypeService
    {
        public Task<List<OperationTypeDTOResponse>> GetAll();
    }
}
