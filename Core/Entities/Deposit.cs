
using Infrastructure.Base;

namespace Core.Entities
{
    public class Deposit : BaseEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public string FromAddress { get; set; }
    }
}
