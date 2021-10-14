using HR.LeaveManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs.LeaveAllocation
{
    public class CreateLeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }

        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}
