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
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(2).WithMessage("Por favor introduzca mímino 2 carácteres.");

            RuleFor(book => book.Publisher)
               .NotEmpty().WithMessage("Este campo no puede estar vacío.");

            RuleFor(book => book.Isbn)
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(13).WithMessage("Por favor introduzca mímino 13 carácteres.");

            RuleFor(book => book.Genre)
              .NotEmpty().WithMessage("Este campo no puede estar vacío.")
              .MinimumLength(2).WithMessage("Por favor introduzca mímino 2 carácteres.");
        }
    }
}
