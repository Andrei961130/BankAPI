
using Infrastructure.Base;

namespace Core.Entities
{
    public class TradeOrder : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int OperationId { get; set; }
        public int TradeOrderTypeId { get; set; }

    }
}
