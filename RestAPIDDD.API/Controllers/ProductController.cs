using Microsoft.AspNetCore.Mvc;
using RestAPIDDD.Application;
using System;
using System.Collections.Generic;

namespace RestAPIDDD.API.Controllers
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _productApplicationService;

        public ProductController(IProductApplicationService productApplicationService)
        {
            _productApplicationService = productApplicationService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductDto>> Get()
        {
            var products = _productApplicationService.GetAll();

            return Ok(products);
        }

        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetById(Guid id)
        {
            var product = _productApplicationService.GetById(id);

            return product;
        }

        [HttpPost]
        public ActionResult Post([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _productApplicationService.Add(productDto);

                return Ok("Product registered");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpPut]
        public ActionResult Put([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _productApplicationService.Update(productDto);
                return Ok("Product updated");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        [HttpDelete]
        public ActionResult Delete([FromBody] ProductDto productDto)
        {
            try
            {
                if (productDto == null)
                    return NotFound();

                _productApplicationService.Remove(productDto);
                return Ok("Product removed");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}