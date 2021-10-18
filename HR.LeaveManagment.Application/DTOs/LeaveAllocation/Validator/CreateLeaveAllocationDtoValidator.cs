using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HR.LeaveManagment.Application.Contracts.Persistence;

namespace HR.LeaveManagment.Application.DTOs.LeaveAllocation.Validator
{
    public class CreateLeaveAllocationDtoValidator : AbstractValidator<LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public CreateLeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            Include(new ILeaveAllocationDtoValidator(_leaveAllocationRepository));
        }
    }
}
