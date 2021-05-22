using Domain.Modules.Cadastro;
using FluentValidation;

namespace CrossCutting.FluentValidations.Cadastro
{
    public class ClienteValidation : AbstractValidator<Cliente>
    {
        public ClienteValidation()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório.")
                .Length(2, 200).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres.");

            RuleFor(c => c.Cpf)
                .NotEmpty().WithMessage("O campo {PropertyName} é obrigatório.")
                .Length(14).WithMessage("O campo {PropertyName} inválido..")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");
        }
    }
}
