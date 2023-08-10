using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("*Category name must not be empty");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("*Category name  must consist of at least 3 letters");
            RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("*Category name  must be no more than 30 letters");
            RuleFor(x => x.Description).NotEmpty().WithMessage("*Category Description must not be empty");
        }
    }
}
