using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class HeadingValidator : AbstractValidator<Heading>
    {
        public HeadingValidator()
        {
            RuleFor(x => x.HeadingName).NotEmpty().WithMessage("*Heading name must not be empty");
            RuleFor(x => x.HeadingName).MinimumLength(3).WithMessage("*Heading name  must consist of at least 3 letters");
            RuleFor(x => x.HeadingName).MaximumLength(30).WithMessage("*Heading name  must be no more than 30 letters");
            
        }
    }

}
