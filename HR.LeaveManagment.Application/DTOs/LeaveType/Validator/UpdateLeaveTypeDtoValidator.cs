using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace HR.LeaveManagment.Application.DTOs.LeaveType.Validator
{
    public class UpdateLeaveTypeDtoValidator : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidator()
        {
            Include(new BaseLeaveTypeDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
