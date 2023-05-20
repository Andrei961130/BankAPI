
using Infrastructure.Base;

namespace Core.Entities
{
    public class OperationType : BaseEntity
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public virtual ICollection<Operation> Operations { get; set;}
    }
}
