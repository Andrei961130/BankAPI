
using Infrastructure.Base;

namespace Core.Entities
{
    public class Operation : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public int OperationTypeId { get; set; }

        public virtual OperationType OperationType { get; set; }
        public virtual ICollection<TradeOrder> TradeOrders { get; set; }
        public virtual ICollection<Deposit> Deposits { get; set; }
        public virtual ICollection<Withdrawal> Withdrawals { get; set; }
    }
}
