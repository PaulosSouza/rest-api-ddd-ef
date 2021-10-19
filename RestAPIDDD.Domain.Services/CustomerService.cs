using RestAPIDDD.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIDDD.Domain.Services
{
    public class CustomerService : BaseService<Customer>, ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) : base(customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}