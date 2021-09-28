using Microsoft.Extensions.DependencyInjection;

namespace Integro.App.Configurations
{
    public static class MvcConfig
    {
        public static IServiceCollection AddMvcConfiguration(this IServiceCollection services)
        {
            services.AddMvc(o =>
            {
                o.ModelBindingMessageProvider.SetAttemptedValueIsInvalidAccessor((x, y) => "O Valor preenchido é inválido para este campo!");
                o.ModelBindingMessageProvider.SetMissingBindRequiredValueAccessor(x => "Este campo precisa ser preenchido!");
                o.ModelBindingMessageProvider.SetMissingKeyOrValueAccessor(() => "Este campo precisa ser preenchido!");
                o.ModelBindingMessageProvider.SetMissingRequestBodyRequiredValueAccessor(() => "É necessário que o body na requisição não esteja vazio!");
                o.ModelBindingMessageProvider.SetNonPropertyAttemptedValueIsInvalidAccessor((x) => "O valor preenchido é inválido para este campo!");
                o.ModelBindingMessageProvider.SetNonPropertyUnknownValueIsInvalidAccessor(() => "O Valor preenchido é inválido para este campo!");
                o.ModelBindingMessageProvider.SetNonPropertyValueMustBeANumberAccessor(() => "Este campo deve ser númerico!");
                o.ModelBindingMessageProvider.SetUnknownValueIsInvalidAccessor((x) => "O Valor preenchido é inválido para este campo!");
                o.ModelBindingMessageProvider.SetValueIsInvalidAccessor((x) => "O Valor preenchido é inválido para este campo!");
                o.ModelBindingMessageProvider.SetValueMustBeANumberAccessor((x) => "Este campo deve ser númerico!");
                o.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor((x) => "Este campo precisa ser preenchido!");

            });

            return services;
        }
    }
}
