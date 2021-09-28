using Integro.Business.Interfaces;
using Integro.Data.Context;
using Integro.Data.Repository;
using Microsoft.AspNetCore.Mvc.DataAnnotations;
using Microsoft.Extensions.DependencyInjection;
using static Integro.App.Extensions.MoedaAttributeAdapter;

namespace Integro.App.Configurations
{
    public static class DependencyInjectionConfig 
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IEnderecoRepository, EnderecoRepository>();
            services.AddScoped<IFornecedorRepository, FornecedorRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddSingleton<IValidationAttributeAdapterProvider, MoedaValidationAttributeAdapterProvider>();

            return services;
        }
    }
}
