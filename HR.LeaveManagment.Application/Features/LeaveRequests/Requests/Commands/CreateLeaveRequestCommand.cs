using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<int>
    {
        public LeaveRequestDto LeaveRequestDto { get; set; }
    }
}
