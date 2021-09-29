using FluentValidation;

namespace Integro.Business.Models.Validations
{
    public class EnderecoValidation : AbstractValidator<Endereco>
    {
        public EnderecoValidation()
        {
            RuleFor(c => c.Logradouro)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 200).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Bairro)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 100).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Cep)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(8).WithMessage("Este campo deve ter {MinLenght} caracteres!");

            RuleFor(c => c.Cidade)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 100).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Estado)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(2, 50).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");

            RuleFor(c => c.Numero)
                .NotEmpty().WithMessage("Este campo não pode ficar em branco!")
                .Length(1, 50).WithMessage("Este campo deve ter entre {MinLenght} e {MaxLenght} caracteres!");
        }
    }
}
