using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    class ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        public Task<LeaveAllocation> Add(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> Delete(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<LeaveAllocation>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveAllocation> Update(LeaveAllocation entity)
        {
            throw new NotImplementedException();
        }
    }
}
