using HR.LeaveManagment.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;


namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Queries
{
    public class GetLeaveAllocationListRequest : IRequest<List<LeaveAllocationDto>>
    {

    }
}
