using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.DTOs;    

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateLeaveAllocationCommand : IRequest<Unit>
    {
        public LeaveAllocationDto LeaveAllocationDto { get; set; }
    }
}
