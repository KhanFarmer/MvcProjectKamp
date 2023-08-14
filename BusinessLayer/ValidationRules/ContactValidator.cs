using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class ContactValidator : AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            RuleFor(x => x.Subject).NotEmpty().WithMessage("*Subject must not be empty");
            RuleFor(x => x.UserMail).MinimumLength(3).WithMessage("*UserMail must consist of at least 3 letters");
            RuleFor(x => x.Subject).MaximumLength(40).WithMessage("*Subject name  must be no more than 40 letters");
            RuleFor(x => x.Message).MinimumLength(10).WithMessage("*Message must consist of at least 10 letters");
            RuleFor(x => x.Message).MaximumLength(100).WithMessage("*Mesaage must be no more than 100 letters");
           
        }
    }
}
