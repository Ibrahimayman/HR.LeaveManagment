using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Persistence.Contracts;
using MediatR;
using AutoMapper;
using HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Queries;

namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationDetailHandler : IRequestHandler<GetLeaveAllocationDetailRequest, LeaveAllocationDto>
    {
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;


        public GetLeaveAllocationDetailHandler(ILeaveAllocationRepository LeaveAllocationRepository, IMapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<LeaveAllocationDto> Handle(GetLeaveAllocationDetailRequest request, CancellationToken cancellationToken)
        {
            var LeaveAllocation = await _LeaveAllocationRepository.GetLeaveAllocationWithDetails(request.Id);
            return _mapper.Map<LeaveAllocationDto>(LeaveAllocation);
        }

    }
}
