using System;

namespace RestAPIDDD.Application
{
    public class CustomerDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
    }
}