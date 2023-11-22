using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator() 
        {
            CascadeMode = CascadeMode.Stop;

            RuleFor(author => author.FirstName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El nombre no puede estar vacío.")
                .MaximumLength(50).WithMessage("Este campo no permite más de 50 carácteres.");

            RuleFor(author => author.LastName)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El apellido no puede estar vacío.")
                .MaximumLength(50).WithMessage("Este campo no permite más de 50 carácteres.");
        }
    }
}
