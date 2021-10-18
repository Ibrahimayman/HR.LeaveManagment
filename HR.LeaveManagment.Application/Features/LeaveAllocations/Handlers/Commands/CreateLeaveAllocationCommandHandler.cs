using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using AutoMapper;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Commands;
using System.Threading.Tasks;
using System.Threading;
using HR.LeaveManagment.Application.Contracts.Persistence;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Handlers.Commands
{
    public class CreateLeaveAllocationCommandHandler : IRequestHandler<CreateLeaveAllocationCommand, int>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public CreateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<int> Handle(CreateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var LeaveAllocation = _mapper.Map<LeaveAllocation>(request.CreateLeaveAllocationDto);
            LeaveAllocation = await _leaveAllocationRepository.Add(LeaveAllocation);
            return LeaveAllocation.Id;
        }
    }
}
