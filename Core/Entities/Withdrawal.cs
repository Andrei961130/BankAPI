
using Infrastructure.Base;

namespace Core.Entities
{
    public class Withdrawal : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string ToAddress { get; set; }
        public bool WasApprovedBy2FA { get; set; }
        public int OperationId { get; set; }
    }
}
