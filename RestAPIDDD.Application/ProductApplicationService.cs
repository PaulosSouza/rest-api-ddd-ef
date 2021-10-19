using AutoMapper;
using RestAPIDDD.Domain;
using RestAPIDDD.Domain.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIDDD.Application
{
    public class ProductApplicationService : IProductApplicationService
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductApplicationService(
            IProductService productService,
            IMapper mapper)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public void Add(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);

            _productService.Add(product);
        }

        public IEnumerable<ProductDto> GetAll()
        {
            var products = _productService.GetAll();
            return _mapper.Map<IEnumerable<ProductDto>>(products);
        }

        public ProductDto GetById(Guid id)
        {
            var product = _productService.GetById(id);
            return _mapper.Map<ProductDto>(product);
        }

        public void Remove(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productService.Remove(product);
        }

        public void Update(ProductDto productDto)
        {
            var product = _mapper.Map<Product>(productDto);
            _productService.Update(product);
        }
    }
}