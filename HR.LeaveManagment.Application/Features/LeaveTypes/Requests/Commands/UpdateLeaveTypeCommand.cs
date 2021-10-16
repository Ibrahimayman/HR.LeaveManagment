using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.DTOs;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Commands
{
    public class UpdateLeaveTypeCommand : IRequest<Unit>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
