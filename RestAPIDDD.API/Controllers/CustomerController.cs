using Microsoft.AspNetCore.Mvc;
using RestAPIDDD.Application;
using System;
using System.Collections.Generic;

namespace RestAPIDDD.API.Controllers
{
    [Route("api/customer")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerApplicationService _customerApplicationService;

        public CustomerController(ICustomerApplicationService customerApplicationService)
        {
            _customerApplicationService = customerApplicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomerDto>> Get()
        {
            var customers = _customerApplicationService.GetAll();

            return Ok(customers);
        }

        [HttpGet("{id}")]
        public ActionResult<CustomerDto> GetById(Guid id)
        {
            var customer = _customerApplicationService.GetById(id);

            return customer;
        }

        [HttpPost]
        public ActionResult Post([FromBody] CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                    return NotFound();

                _customerApplicationService.Add(customerDto);

                return Ok("Customer registered");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                    return NotFound();

                _customerApplicationService.Update(customerDto);
                return Ok("Customer updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null)
                    return NotFound();

                _customerApplicationService.Remove(customerDto);
                return Ok("Customer removed");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}