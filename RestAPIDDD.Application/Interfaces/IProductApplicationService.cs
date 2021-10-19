using System;
using System.Collections.Generic;
using System.Text;

namespace RestAPIDDD.Application
{
    public interface IProductApplicationService
    {
        void Add(ProductDto productDto);

        void Update(ProductDto productDto);

        void Remove(ProductDto productDto);

        IEnumerable<ProductDto> GetAll();

        ProductDto GetById(Guid id);
    }
}