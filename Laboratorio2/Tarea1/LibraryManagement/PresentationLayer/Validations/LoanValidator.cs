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
            RuleFor(loan => loan.IdBook)
               .NotEmpty().WithMessage("No hay libros disponibles o no ha escogido ninguno.");

            RuleFor(loan => loan.Customer)
               .NotEmpty().WithMessage("No puede dejar campo vacío, por favor completar el nombre del cliente.");

            RuleFor(loan => loan.LoanDate)
                .NotEmpty().WithMessage("Por favor, ingrese una fecha.")
                .Must(date => date >= DateTime.Today).WithMessage("Ingrese una fecha válida y no anterior a la actual.");

            RuleFor(loan => loan.LoanDate)
                .NotEmpty().WithMessage("Por favor, ingrese la fecha de préstamo.")
                .LessThanOrEqualTo(loan => loan.ReturnEstimatedDate)
                .WithMessage("La fecha de préstamo no puede ser mayor que la fecha de devolución.");

            RuleFor(loan => loan.ReturnEstimatedDate)
                .NotEmpty().WithMessage("Por favor, ingrese una fecha.")
                .Must((loan, returnDate) => returnDate.Date >= loan.LoanDate.Date)
                .WithMessage("La fecha de devolución no puede ser inferior a la fecha de préstamo.");
        }
    }
}
