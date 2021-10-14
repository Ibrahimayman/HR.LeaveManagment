using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {

        Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id);

        Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails();
    }
}
