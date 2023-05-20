using Core.DTOs;
using Core.Entities;

namespace Core.Mappers
{
    public static class DepositMapperMethods
    {
        public static DepositDTOResponse ToDTO(this Deposit deposit)
        {
            return new DepositDTOResponse()
            {
                Id = deposit.Id,
                Amount = deposit.Amount,
                FromAddress = deposit.FromAddress
            };
        }

        public static Deposit ToModel(this DepositDTORequest deposit)
        {
            return new Deposit()
            {
                Amount = deposit.Amount,
                FromAddress = deposit.FromAddress
            };
        }
    }
}
