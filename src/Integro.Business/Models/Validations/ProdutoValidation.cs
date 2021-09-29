using FluentValidation;

namespace Integro.Business.Models.Validations
{
    public class ProdutoValidation : AbstractValidator<Produto>
    {
        public ProdutoValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 200).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Descricao)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 1000).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Valor)
                .GreaterThan(0).WithMessage("Este campo deve ser maior que {ComparisonValue}");
        }
    }
}
