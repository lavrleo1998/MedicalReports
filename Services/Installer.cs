using Microsoft.Extensions.DependencyInjection;
using Repository.ProtocolParameterProvider;
using Repository.TemplateProvider;
using Repository.Repository;
using Storage;
using Services;

namespace Services
{
    public static class Installer
    {
        public static ServiceProvider Init()
        {
            var serviceConllection = new ServiceCollection()
                .AddDbContext<AppDbContext>()
                .AddScoped<IProtocolParameterService, ProtocolParameterService>()
                .AddScoped<IProtocolParameterProvider, ProtocolParameterProvider>()
                .AddScoped<ITemplateService, TemplateService>()
                .AddScoped<ITemplateProvider, TemplateProvider>();
            return serviceConllection.BuildServiceProvider();
        }


        //вариант для asp.net
        public static void AddBuisnessServices(this IServiceCollection container)
        {
            container
                .AddDbContext<AppDbContext>()
                ;
            ///в asp.net не нужно возвращать контейнер(((
        }
    }
}
