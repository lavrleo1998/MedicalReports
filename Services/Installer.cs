using Microsoft.Extensions.DependencyInjection;
using Repository;
using Storage;

namespace Services
{
    public static class Installer
    {
        public static ServiceProvider Init()
        {
            var serviceConllection = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddScoped<IParamService, ParamService>()
                .AddScoped<IParamProvider, ParamProvider>()
                .AddScoped<ITemplateService, TemplateService>()
                .AddScoped<ITemplateProvider, TemplateProvider>()
                .AddScoped<IOrganService, OrganService>()
                .AddScoped<IOrganProvider, OrganProvider>();
            return serviceConllection.BuildServiceProvider();
        }


        ////вариант для asp.net в asp.net не нужно возвращать контейнер
        //public static void AddBuisnessServices(this IServiceCollection container)
        //{
        //    container
        //        .AddDbContext<AppDbContext>()
        //        ;
        //}
    }
}
