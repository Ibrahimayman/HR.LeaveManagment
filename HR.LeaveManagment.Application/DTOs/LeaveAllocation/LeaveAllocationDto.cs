using HR.LeaveManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs
{
    public class LeaveAllocationDto : BaseDto
    {
        public int NumberOfDays { get; set; }

        public EmployeeDto Employee { get; set; }

        public string EmployeeId { get; set; }

        public LeaveTypeDto LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        public int Period { get; set; }
    }
}
