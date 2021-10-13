using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using HR.LeaveManagment.Application.DTOs;
using HR.LeaveManagment.Application.DTOs.LeaveRequest;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<LeaveRequest, LeaveRequestDto>().ReverseMap();

            CreateMap<LeaveRequest, LeaveRequestListDto>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationDto>().ReverseMap();

            CreateMap<LeaveType, LeaveTypeDto>().ReverseMap();
        }
    }
}
