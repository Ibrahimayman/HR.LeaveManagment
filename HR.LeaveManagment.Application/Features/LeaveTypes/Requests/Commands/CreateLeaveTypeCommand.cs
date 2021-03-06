using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Responses;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Commands
{
    public class CreateLeaveTypeCommand : IRequest<BaseCommonResponse>
    {
        public LeaveTypeDto LeaveTypeDto { get; set; }
    }
}
