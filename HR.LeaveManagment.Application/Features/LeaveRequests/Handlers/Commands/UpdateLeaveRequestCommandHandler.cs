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
    public class UpdateLeaveRequestCommandHandler : IRequestHandler<UpdateLeaveRequestCommand, Unit>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(UpdateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var leaveRequest = await _leaveRequestRepository.Get(request.LeaveRequestDto.Id);
            if (request.LeaveRequestDto != null)
            {
                _mapper.Map(request.LeaveRequestDto, leaveRequest);

                await _leaveRequestRepository.Update(leaveRequest);

                return Unit.Value;
            }
            else if (request.ChangeLeaveRequestApprovalDto != null) {
                await _leaveRequestRepository.ChangeApprovalStatus(leaveRequest, request.LeaveRequestDto.Approved);
            }
            return Unit.Value;

        }
    }
}
