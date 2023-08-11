using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("*Writer name must not be empty");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("*Writer surname must not be empty");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("*Writer Title must not be empty");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("*Writer name  must consist of at least 2 letters");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("*Writer surname  must consist of at least 2 letters");
            RuleFor(x => x.WriterName).MaximumLength(30).WithMessage("*Writer name  must be no more than 30 letters");
            RuleFor(x => x.WriterSurname).MaximumLength(30).WithMessage("*Writer surname  must be no more than 30 letters");
            
        }

    }
}
