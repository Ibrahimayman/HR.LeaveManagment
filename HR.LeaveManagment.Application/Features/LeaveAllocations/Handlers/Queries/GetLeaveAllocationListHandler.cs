using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Features.LeaveAllocations.Requests.Queries;
using HR.LeaveManagment.Application.Persistence.Contracts;
using MediatR;
using AutoMapper;


namespace HR.LeaveManagment.Application.Features.LeaveAllocations.Handlers.Queries
{
    public class GetLeaveAllocationListHandler : IRequestHandler<GetLeaveAllocationListRequest, List<LeaveAllocationDto>>
    {
        private readonly ILeaveAllocationRepository _LeaveAllocationRepository;
        private readonly IMapper _mapper;

        public GetLeaveAllocationListHandler(ILeaveAllocationRepository LeaveAllocationRepository, IMapper mapper)
        {
            _LeaveAllocationRepository = LeaveAllocationRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveAllocationDto>> Handle(GetLeaveAllocationListRequest request, CancellationToken cancellationToken)
        {
            var LeaveAllocationList = await _LeaveAllocationRepository.GetLeaveAllocationsWithDetails();
            return _mapper.Map<List<LeaveAllocationDto>>(LeaveAllocationList);
        }
    }
}
