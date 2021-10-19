using Autofac;
using AutoMapper;
using RestAPIDDD.Application;
using RestAPIDDD.Domain.Core;
using RestAPIDDD.Domain.Services;

namespace RestAPIDDD.Infrastructure
{
    public static class ConfigurationIoc
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CustomerApplicationService>().As<ICustomerApplicationService>();
            builder.RegisterType<ProductApplicationService>().As<IProductApplicationService>();
            builder.RegisterType<CustomerService>().As<ICustomerService>();
            builder.RegisterType<ProductService>().As<IProductService>();
            builder.RegisterType<CustomerRepository>().As<ICustomerRepository>();
            builder.RegisterType<ProductRepository>().As<IProductRepository>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CustomerProfile());
                cfg.AddProfile(new ProductProfile());
            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper())
                .As<IMapper>()
                .InstancePerLifetimeScope();
        }
    }
}