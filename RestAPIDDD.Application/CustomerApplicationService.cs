using AutoMapper;
using RestAPIDDD.Domain;
using RestAPIDDD.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIDDD.Application
{
    public class CustomerApplicationService : ICustomerApplicationService
    {
        private readonly ICustomerService _customerService;
        private readonly IMapper _mapper;

        public CustomerApplicationService(
            ICustomerService customerService,
            IMapper mapper)
        {
            _customerService = customerService;
            _mapper = mapper;
        }

        public void Add(CustomerDto customerDto)
        {
            Customer customer = _mapper.Map<Customer>(customerDto);

            _customerService.Add(customer);
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            var customers = _customerService.GetAll();
            return _mapper.Map<IEnumerable<CustomerDto>>(customers);
        }

        public CustomerDto GetById(Guid id)
        {
            var customer = _customerService.GetById(id);
            return _mapper.Map<CustomerDto>(customer);
        }

        public void Remove(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.Remove(customer);
        }

        public void Update(CustomerDto customerDto)
        {
            var customer = _mapper.Map<Customer>(customerDto);
            _customerService.Update(customer);
        }
    }
}