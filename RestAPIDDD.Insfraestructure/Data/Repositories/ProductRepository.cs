using RestAPIDDD.Domain;
using RestAPIDDD.Domain.Core;

namespace RestAPIDDD.Infrastructure
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        private readonly SqlContext _sqlContext;

        public ProductRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}