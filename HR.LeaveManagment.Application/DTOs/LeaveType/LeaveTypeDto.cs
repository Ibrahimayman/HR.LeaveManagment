using HR.LeaveManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs
{
    public class LeaveTypeDto : BaseDto
    {
        public string Name { get; set; }
        
        public int DefaultDays { get; set; }
    }
}
