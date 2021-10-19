using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPIDDD.Domain
{
    [Table("Product")]
    public class Product : Base
    {
        public string Name { get; set; }
        public decimal Value { get; set; }
        public bool IsAvailable { get; set; }
    }
}