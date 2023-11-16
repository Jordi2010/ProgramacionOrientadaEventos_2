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
            RuleFor(reeturn => reeturn.IdLoan)
                .NotEmpty().WithMessage("Por favor llene los campos necesarios.");

            RuleFor(reeturn => reeturn.ActualReturnDate)
            .NotEmpty().WithMessage("Por favor ingrese la fecha de devolución.")
            .Must(date => date > DateTime.MinValue).WithMessage("Por favor ingrese una fecha válida.");
        }
    }
}
