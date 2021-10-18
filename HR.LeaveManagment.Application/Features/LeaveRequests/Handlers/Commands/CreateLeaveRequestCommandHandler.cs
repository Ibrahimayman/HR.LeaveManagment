using System;
using System.Collections.Generic;
using System.Text;
using MediatR;
using HR.LeaveManagment.Application.Features.LeaveRequests.Requests.Commands;
using System.Threading.Tasks;
using System.Threading;
using HR.LeaveManagment.Application.Contracts.Persistence;
using AutoMapper;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.Contracts.Infrastructure;
using HR.LeaveManagment.Application.Responses;
using HR.LeaveManagment.Application.DTOs.LeaveRequest.Validator;
using System.Linq;
using HR.LeaveManagment.Application.Models;

namespace HR.LeaveManagment.Application.Features.LeaveRequests.Handlers.Commands
{
    public class CreateLeaveRequestCommandHandler : IRequestHandler<CreateLeaveRequestCommand, BaseCommonResponse>
    {
        private readonly ILeaveRequestRepository _leaveRequestRepository;
        private readonly ILeaveTypeRepository _leaveTypeRepository;
        private readonly IEmailSender _emailSender;
        private readonly IMapper _mapper;

        public CreateLeaveRequestCommandHandler(ILeaveRequestRepository leaveRequestRepository, ILeaveTypeRepository leaveTypeRepository, IMapper mapper, IEmailSender emailSender)
        {
            _leaveRequestRepository = leaveRequestRepository;
            _leaveTypeRepository = leaveTypeRepository;
            _mapper = mapper;
            _emailSender = emailSender;
        }

        public async Task<BaseCommonResponse> Handle(CreateLeaveRequestCommand request, CancellationToken cancellationToken)
        {
            var response = new BaseCommonResponse();
            var validator = new CreateLeaveRequestDtoValidator(_leaveTypeRepository);
            var validationResult = await validator.ValidateAsync(request.LeaveRequestDto);

            if (validationResult.IsValid == false) {
                response.Success = false;
                response.Message = "Creation Failed";
                response.Errors = validationResult.Errors.Select(q => q.ErrorMessage).ToList();
            }

            var LeaveRequest = _mapper.Map<LeaveRequest>(request.LeaveRequestDto);
            LeaveRequest = await _leaveRequestRepository.Add(LeaveRequest);


            response.Success = true;
            response.Message = "Creation Successful";
            response.Id = LeaveRequest.Id;


            var email = new Email
            {
                To = "employee.org.com",
                Body = $"your leave request for {request.LeaveRequestDto.StartDate:D} to {request.LeaveRequestDto.EndDate:D}" +
                $"has been submitted successfully",
                Subject = "leave request submitted"
            };

            try
            {
                await _emailSender.SendEmail(email);
            }
            catch (Exception)
            {

            }

            return response;
        }
    }
}
