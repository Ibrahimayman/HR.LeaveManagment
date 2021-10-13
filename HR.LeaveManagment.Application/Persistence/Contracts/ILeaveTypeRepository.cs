using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HR.LeaveManagment.Domain;


namespace HR.LeaveManagment.Application.Persistence.Contracts
{
    public class ILeaveTypeRepository : IGenericRepository<LeaveType>
    {
        public Task<LeaveType> Add(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> Delete(LeaveType entity)
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> Get(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IReadOnlyList<LeaveType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<LeaveType> Update(LeaveType entity)
        {
            throw new NotImplementedException();
        }
    }
}
