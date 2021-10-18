using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace HR.LeaveManagment.Application.DTOs.LeaveType.Validator
{
    public class UpdateLeaveTypeDtoValidatorb : AbstractValidator<LeaveTypeDto>
    {
        public UpdateLeaveTypeDtoValidatorb()
        {
            Include(new BaseLeaveTypeDtoValidator());

            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
