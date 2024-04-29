using Microsoft.Extensions.DependencyInjection;
using MultiLayerAspNetCore.Core.Interface;
using MultiLayerAspNetCore.Core.Service;
using MultiLayerAspNetCore.Data.Repository;
using MultiLayerAspNetCore.Domain.Interface;

namespace MultiLayerAspNetCore.IOC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IClientService, ClientService>();
            services.AddScoped<IClientRepository, ClientRepository>();
        }
    }
}