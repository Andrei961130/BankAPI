
using Core.DTOs;
using Core.MapperConfig;
using Core.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class OperationTypeService : IOperationTypeService
    {
        public IOperationTypeRepository OperationTypeRepository { get; set; }

        public OperationTypeService(IOperationTypeRepository operationTypeRepository)
        {
            OperationTypeRepository = operationTypeRepository;
        }

        public async Task<List<OperationTypeDTOResponse>> GetAll()
        {
            var operationTypes = OperationTypeRepository.GetAll();

            return await operationTypes.Select(ot => ot.ToDTO()).ToListAsync();
        }
    }
}
