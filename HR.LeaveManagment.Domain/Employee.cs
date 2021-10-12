using System;
using System.Collections.Generic;
using System.Text;


namespace HR.LeaveManagment.Domain
{
    public class Employee
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string TaxId { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime DateJoined { get; set; }
    }
}
