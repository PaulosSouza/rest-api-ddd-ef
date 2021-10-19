using RestAPIDDD.Domain;
using RestAPIDDD.Domain.Core;

namespace RestAPIDDD.Infrastructure
{
    public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
    {
        private readonly SqlContext _sqlContext;

        public CustomerRepository(SqlContext sqlContext) : base(sqlContext)
        {
            _sqlContext = sqlContext;
        }
    }
}