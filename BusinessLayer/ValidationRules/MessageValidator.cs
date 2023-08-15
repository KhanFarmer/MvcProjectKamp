using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class MessageValidator : AbstractValidator<Message>
    {
        public MessageValidator()
        {
            RuleFor(x => x.SenderMail).NotEmpty().WithMessage("*Sender Mail must not be empty");
            RuleFor(x => x.ReceiverMail).NotEmpty().WithMessage("*Receiver Mail  must not be empty");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("*Subject must not be empty");
            RuleFor(x => x.MessageContent).NotEmpty().WithMessage("*Message Content  must not be empty");
            
            RuleFor(x => x.MessageContent).MaximumLength(100).WithMessage("*Message Content surname  must be no more than 100 letters");
            RuleFor(x => x.Subject).MaximumLength(30).WithMessage("*Subject must be no more than 30 letters");

        }
    }
}
