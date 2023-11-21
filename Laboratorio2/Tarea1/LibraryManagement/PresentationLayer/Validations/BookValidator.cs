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
            CascadeMode = CascadeMode.Stop; // Detiene la validación después de la primera regla que falle para todas las propiedades

            RuleFor(book => book.Title)
                  .NotEmpty().WithMessage("Este campo no puede estar vacío.")
                  .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 caracteres.")
                  .MaximumLength(100).WithMessage("No se permiten más de 100 caracteres.");

            RuleFor(book => book.Publisher)
                  .NotEmpty().WithMessage("Este campo no puede estar vacío.");

            RuleFor(book => book.Isbn)
                  .NotEmpty().WithMessage("Este campo no puede estar vacío.")
                  .MinimumLength(13).WithMessage("Por favor introduzca mínimo 13 caracteres.")
                  .MaximumLength(13).WithMessage("No se permiten más de 13 carácteres.");

            RuleFor(book => book.Genre)
                  .NotEmpty().WithMessage("Este campo no puede estar vacío.")
                  .MinimumLength(5).WithMessage("Por favor introduzca mínimo 5 caracteres.")
                  .MaximumLength(100).WithMessage("No se permiten más de 100 cáracteres.");
        }
    }
}
