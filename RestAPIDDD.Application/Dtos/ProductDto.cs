using System;

namespace RestAPIDDD.Application
{
    public class ProductDto
    {
        public Guid? Id { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
    }
}