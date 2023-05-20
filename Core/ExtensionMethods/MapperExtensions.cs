using Core.DTOs;
using Core.Entities;

namespace Core.ExtensionMethods
{
    public static class MapperExtensions
    {
        public static DepositDTOResponse ToDTO(this Deposit deposit)
        {
            return new DepositDTOResponse()
            {
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

        public static OperationTypeDTOResponse ToDTO(this OperationType operationType)
        {
            return new OperationTypeDTOResponse()
            {
                Name = operationType.Name
            };
        }

        public static TradeOrderDTOResponse ToDTO(this TradeOrder tradeOrder)
        {
            return new TradeOrderDTOResponse()
            {
                Amount = tradeOrder.Amount,
                TradeOrderType = tradeOrder.TradeOrderType?.Name
            };
        }

        public static WithdrawalDTOResponse ToDTO(this Withdrawal withdrawal)
        {
            return new WithdrawalDTOResponse()
            {
                Amount = withdrawal.Amount,
                ToAddress = withdrawal.ToAddress
            };
        }
    }
}
