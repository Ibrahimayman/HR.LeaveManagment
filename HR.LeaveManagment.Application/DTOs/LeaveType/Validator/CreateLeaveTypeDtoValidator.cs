using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace HR.LeaveManagment.Application.DTOs.LeaveType.Validator
{
    public class CreateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        public CreateLeaveTypeDtoValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 chars");


            RuleFor(p => p.DefaultDays)
               .NotEmpty().WithMessage("{PropertyName} is required")
               .NotNull()
               .GreaterThan(0).WithMessage("{PropertyName} must be at least 1.")
               .LessThan(100).WithMessage("{PropertyName} must be at least 100.");

        }
    }
}
