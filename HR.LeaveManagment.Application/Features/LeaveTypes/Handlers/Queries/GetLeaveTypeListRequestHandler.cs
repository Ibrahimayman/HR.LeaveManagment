using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.Features.LeaveTypes.Requests.Queries;
using HR.LeaveManagment.Application.Persistence.Contracts;
using MediatR;
using AutoMapper;

namespace HR.LeaveManagment.Application.Features.LeaveTypes.Handlers.Queries
{
    public class GetLeaveTypeListRequestHandler : IRequestHandler<GetLeaveTypeListRequest, List<LeaveTypeDto>>
    {
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IMapper _mapper;
        public GetLeaveTypeListRequestHandler(ILeaveTypeRepository leaveTypeRepository,IMapper mapper)
        {
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
        }

        public async Task<List<LeaveTypeDto>> Handle(GetLeaveTypeListRequest request, CancellationToken cancellationToken)
        {
            var leaveTypes = await _leaveTypeRepository.GetAll();
            return _mapper.Map<List<LeaveTypeDto>>(leaveTypes);
        }

    }
}
