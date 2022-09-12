using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace JapBackend.Core.Requests.User.Validations
{
    public class UserInsertRequestValidator : AbstractValidator<UserInsertRequest>
    {
        public UserInsertRequestValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .MinimumLength(2);
            
            RuleFor(x => x.LastName)
                .NotEmpty()
                .MinimumLength(2);
            
            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();
            
            RuleFor(x => x.PhoneNumber)
                .NotEmpty()
                .MinimumLength(2);
            
            RuleFor(x => x.Password)
                .Equal(customer => customer.ConfirmPassword)
                .When(customer => !String.IsNullOrWhiteSpace(customer.Password));
            
            RuleFor(x => x.RoleId)
                .NotNull();
        }
    }
}