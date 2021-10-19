using AutoMapper;
using RestAPIDDD.Domain;

namespace RestAPIDDD.Application
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<CustomerDto, Customer>();

            CreateMap<Customer, CustomerDto>();
        }
    }
}