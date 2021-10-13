using HR.LeaveManagment.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagment.Application.DTOs
{
    public class EmployeeDto : BaseDto
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
