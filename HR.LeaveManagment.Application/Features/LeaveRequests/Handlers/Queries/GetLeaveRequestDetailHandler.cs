using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Application.Contracts.Persistence;
using HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Queries;
using System.Threading.Tasks;
using System.Threading;
using AutoMapper;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Handlers.Queries
{
    public class GetLeaveRequestDetailHandler : IRequestHandler<GetLeaveRequestDetailRequest, LeaveRequestDto>
    {

        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public GetLeaveRequestDetailHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<LeaveRequestDto> Handle(GetLeaveRequestDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequests = await _leaveRequestRepository.GetLeaveRequestWithDetails(request.id);
            return _mapper.Map<LeaveRequestDto>(leaveRequests);
        }

    }
}
