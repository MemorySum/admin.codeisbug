using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace CodeIsBug.Admin.Extension
{
    public class AutofacModuleRegister : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            var assemblesRepositoryNoInterfaces = Assembly.Load("CodeIsBug.Admin.Repository");
            var assemblesServicesNoInterfaces = Assembly.Load("CodeIsBug.Admin.Services");
            builder.RegisterAssemblyTypes(assemblesRepositoryNoInterfaces);
            builder.RegisterAssemblyTypes(assemblesServicesNoInterfaces);
        }
    }
}
