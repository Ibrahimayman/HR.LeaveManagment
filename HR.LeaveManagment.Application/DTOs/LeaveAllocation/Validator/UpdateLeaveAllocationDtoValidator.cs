using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HR.LeaveManagment.Application.Persistence.Contracts;

namespace HR.LeaveManagment.Application.DTOs.LeaveAllocation.Validator
{
    class UpdateLeaveAllocationDtoValidator : AbstractValidator<LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public UpdateLeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            Include(new ILeaveAllocationDtoValidator(_leaveAllocationRepository));


            RuleFor(p => p.Id).NotNull().WithMessage("{PropertyName} must be present");
        }
    }
}
