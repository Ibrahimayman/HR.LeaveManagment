using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Queries;
using System.Threading.Tasks;
using System.Threading;
using HR.LeaveManagment.Application.Contracts.Persistence;
using AutoMapper;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestsListHandler : IRequestHandler<GetLeaveRequestsListRequest, List<LeaveRequestListDto>>
    {
        private readonly ILeaveRequestRepository _LeaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestsListHandler(ILeaveRequestRepository LeaveRequestRepository, IMapper mapper)
        {
            _LeaveRequestRepository = LeaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveRequestListDto>> Handle(GetLeaveRequestsListRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _LeaveRequestRepository.GetLeaveRequestsWithDetails();
            return _mapper.Map<List<LeaveRequestListDto>>(leaveRequests);
        }

    }
}
