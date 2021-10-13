using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagment.Domain;

namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    class IRequestLeaveRepository : IGenericRepository<LeaveRequest>
    {
        public Task<LeaveRequest> Add(LeaveRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequest> Delete(LeaveRequest entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequest> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<LeaveRequest>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveRequest> Update(LeaveRequest entity)
        {
            throw new NotImplementedException();
        }
    }
}
