using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Application.Responses;
using MediatR;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Commands
{
    public class CreateLeaveRequestCommand : IRequest<BaseCommonResponse>
    {
        public CreateLeaveRequestDto LeaveRequestDto { get; set; }
    }
}
