using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;


namespace HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Queries
{
    public class GetLeaveRequestsListRequest : IRequest<List<LeaveRequestListDto>>
    {

    }
}
