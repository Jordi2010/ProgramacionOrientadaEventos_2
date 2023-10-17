using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class LoanValidator : AbstractValidator<Loan>
    {
        public LoanValidator() 
        {
            RuleFor(loan => loan.IdLoan)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(loan => loan.IdBook)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(loan => loan.Customer)
               .NotEmpty().WithMessage("Este campo no puede estar vacío.")
               .MinimumLength(5).WithMessage("Por favor introduzca mímino 5 carácteres.");

            RuleFor(loan => loan.LoanDate)
                .NotEmpty().WithMessage("Por favor, ingrese una fecha.")
                .Must(date => date > DateTime.Now).WithMessage("Ingrese una fecha válida y posterior a la actual.");

            RuleFor(loan => loan.ReturnEstimatedDate)
                .NotEmpty().WithMessage("Por favor, ingrese una fecha.")
                .Must(date => date.Date > DateTime.Today).WithMessage("Ingrese una fecha válida y posterior a la actual.");
        }
    }
}
