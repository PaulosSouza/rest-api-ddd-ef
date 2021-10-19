using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestAPIDDD.Domain
{
    [Table("Customer")]
    public class Customer : Base
    {
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}