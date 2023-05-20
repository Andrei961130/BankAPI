
namespace Core.Entities
{
    public class OperationType
    {
        public int Id { get; set; }
        public string Name{ get; set; }

        public virtual ICollection<Operation> Operations { get; set;}
    }
}
