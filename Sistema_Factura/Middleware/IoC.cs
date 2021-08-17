using Microsoft.Extensions.DependencyInjection;
using Sistema_Factura.Repository;
using Sistema_Factura.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sistema_Factura.Middleware
{
    public static class IoC
    {
        public static IServiceCollection AddDependency(this IServiceCollection services)
        {
            // Inyectar el servicio de Authorización => Cliente
            services.AddTransient<IClienteRepository, ClienteRepository>();

            return services;
        }
    }
}
