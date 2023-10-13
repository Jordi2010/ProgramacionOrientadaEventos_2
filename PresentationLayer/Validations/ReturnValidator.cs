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
            RuleFor(reeturn => reeturn.IdReturn)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(reeturn => reeturn.IdLoan)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(reeturn => reeturn.EstimatedReturnDate)
               .NotEmpty().WithMessage("Ingrese una fecha válida.");

            RuleFor(reeturn => reeturn.ActualReturnDate)
                .NotEmpty().WithMessage("Ingrese una fecha válida.");
        }
    }
}
