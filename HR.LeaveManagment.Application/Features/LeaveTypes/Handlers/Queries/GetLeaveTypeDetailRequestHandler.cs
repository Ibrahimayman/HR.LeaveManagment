using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagment.Application.Contracts.Persistence;
using MediatR;
using AutoMapper;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeDetailRequestHandler : IRequestHandler<GetLeaveTypeDetailRequest, LeaveTypeDto>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeDetailRequestHandler(ILeaveTypeRepository leaveTypeRepository, IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<LeaveTypeDto> Handle(GetLeaveTypeDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.Get(request.Id);
            return _mapper.Map<LeaveTypeDto>(leaveTypes);
        }

    }

}
