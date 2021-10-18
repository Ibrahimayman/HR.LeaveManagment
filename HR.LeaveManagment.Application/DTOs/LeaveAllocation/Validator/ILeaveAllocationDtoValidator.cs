using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;
using HR.LeaveManagment.Application.Contracts.Persistence;


namespace HR.LeaveManagment.Application.DTOs.LeaveAllocation.Validator
{
    public class ILeaveAllocationDtoValidator : AbstractValidator<LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        public ILeaveAllocationDtoValidator(ILeaveAllocationRepository leaveAllocationRepository)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            RuleFor(p => p.NumberOfDays)
                .GreaterThan(0).WithMessage("{PropertyName} must be grater than {ComparisonValue}");


            RuleFor(p => p.Period)
               .GreaterThanOrEqualTo(DateTime.Now.Year).WithMessage("{PropertyName} must be after {ComparisonValue}");

            RuleFor(p => p.LeaveTypeId)
                .GreaterThan(0)
                .MustAsync(async (id, token) =>
                {

                    bool leaveTypeExists = await _leaveAllocationRepository.Exists(id);
                    return !leaveTypeExists;

                }).WithMessage("{PropertyName} dose not exist");
        }
    }
}
