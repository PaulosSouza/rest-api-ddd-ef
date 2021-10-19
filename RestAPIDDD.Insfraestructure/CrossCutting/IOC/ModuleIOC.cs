using Autofac;

namespace RestAPIDDD.Infrastructure
{
    public class ModuleIoc : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            ConfigurationIoc.Load(builder);
        }
    }
}