using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class StatusValidator : AbstractValidator<Status>
    {
        public StatusValidator() 
        {
            RuleFor(Status => Status.IdStatus)
               .Cascade(CascadeMode.Stop)
               .NotEmpty().WithMessage("El ID no puede estar vacío.")
               .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(status => status.BookStatus)
                .NotEmpty().WithMessage("El campo 'BookStatus' no puede estar vacío.")
                .MinimumLength(5).WithMessage("Por favor, introduzca al menos 5 caracteres en el campo 'BookStatus'.")
                .MaximumLength(50).WithMessage("El campo 'BookStatus' no puede tener más de 50 caracteres.");
        }
    }
}
