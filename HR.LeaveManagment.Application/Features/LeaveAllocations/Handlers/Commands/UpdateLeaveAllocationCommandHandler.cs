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
    public class UpdateLeaveAllocationCommandHandler : IRequestHandler<UpdateLeaveAllocationCommand,Unit>
    {
        private readonly ILeaveAllocationRepository _leaveAllocationRepository;
        private readonly IMapper _mapper;

        public UpdateLeaveAllocationCommandHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            _leaveAllocationRepository = leaveAllocationRepository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateLeaveAllocationCommand request, CancellationToken cancellationToken)
        {
            var leaveAllocation = await _leaveAllocationRepository.Get(request.LeaveAllocationDto.Id);

            _mapper.Map(request.LeaveAllocationDto, leaveAllocation);

            await _leaveAllocationRepository.Update(leaveAllocation);

            return Unit.Value;
        }
    }
}
