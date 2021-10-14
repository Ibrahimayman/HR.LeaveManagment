using HR.LeaveManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs
{
    public class CreateLeaveRequestDto : BaseDto
    {
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int LeaveTypeId { get; set; }

        public string RequestComments { get; set; }
    }
}
