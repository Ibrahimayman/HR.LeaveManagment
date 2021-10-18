using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagment.Application.Models;

namespace HR.LeaveManagment.Application.Contracts.Infrastructure
{
    public interface IEmailSender
    {
        Task<bool> SendEmail(Email email);
    }
}
