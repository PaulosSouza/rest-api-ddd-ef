using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIDDD.Application
{
    public interface ICustomerApplicationService
    {
        void Add(CustomerDto customerDto);

        void Update(CustomerDto customerDto);

        void Remove(CustomerDto customerDto);

        IEnumerable<CustomerDto> GetAll();

        CustomerDto GetById(Guid id);
    }
}