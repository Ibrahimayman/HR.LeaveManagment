using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Commands;
using System.Threading.Tasks;
using System.Threading;
using HR.LeaveManagment.Application.Persistence.Contracts;
using AutoMapper;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, int>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var LeaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
            LeaveRequest = await _leaveRequestRepository.Add(LeaveRequest);
            return LeaveRequest.Id;
        }
    }
}
