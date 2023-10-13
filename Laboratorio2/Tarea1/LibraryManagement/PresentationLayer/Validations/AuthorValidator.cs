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
            RuleFor(author => author.IdAuthor)
                .Cascade(CascadeMode.Stop)
                .NotEmpty().WithMessage("El ID no puede estar vacío.")
                .GreaterThan(0).WithMessage("El ID debe ser mayor que cero.");

            RuleFor(author => author.FirstName).NotEmpty()
                .WithMessage("El nombre no puede estar vacío.");

            RuleFor(author => author.LastName).NotEmpty()
                .WithMessage("El apellido no puede estar vacío.");
        }
    }
}
