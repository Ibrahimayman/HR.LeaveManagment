using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Application.DTOs;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<int>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
