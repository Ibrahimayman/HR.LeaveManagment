using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.DTOs.LeaveAllocation;

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateLeaveAllocationCommand : IRequest<int>
    {
        public CreateLeaveAllocationDto CreateLeaveAllocationDto { get; set; }
    }
}
