using HR.LeaveManagment.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace HR.LeaveManagment.Domain
{
    public class LeaveType : BaseDomainEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Default Number Of Days")]
        [Range(1, 25, ErrorMessage = "Please Enter A Valid Number")]

        public int DefaultDays { get; set; }

    }
}
