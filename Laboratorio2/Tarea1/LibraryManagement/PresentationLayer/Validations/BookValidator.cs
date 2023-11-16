using CommonLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PresentationLayer.Validations
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator() 
        {
            RuleFor(book => book.Title)
              .Cascade(CascadeMode.Stop)
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 carácteres.")
              .MaximumLength(100).WithMessage("No se permiten más de 100 carácteres.");

            RuleFor(book => book.Publisher)
               .NotEmpty().WithMessage("Este campo no puede estar vacío.");

            RuleFor(book => book.Isbn)
              .Cascade(CascadeMode.Stop)
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(13).WithMessage("Por favor introduzca mínimo 13 carácteres.")
              .MaximumLength(13).WithMessage("No se permiten más de 13 carácteres.");

            RuleFor(book => book.Genre)
              .Cascade(CascadeMode.Stop)
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 carácteres.")
              .MaximumLength(10).WithMessage("No se permiten más de 10 carácteres.");
        }
    }
}
