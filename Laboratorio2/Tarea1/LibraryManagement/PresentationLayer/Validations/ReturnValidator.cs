using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class ReturnValidator : AbstractValidator<Return>
    {
        public ReturnValidator() 
        {
            RuleFor(Return => Return.IdReturn)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(Return => Return.IdLoan)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(Return => Return.EstimatedReturnDate)
               .NotEmpty().WithMessage("Ingrese una fecha válida.");

            RuleFor(Return => Return.ActualReturnDate)
                .NotEmpty().WithMessage("Ingrese una fecha válida.");
        }
    }
}
