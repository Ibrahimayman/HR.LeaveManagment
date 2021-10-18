using HR.LeaveManagment.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Application.Persistence.Contracts;

namespace HR.LeaveManagment.Persistence.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        private readonly LeaveManagementDbContext _dbContext;
        public LeaveTypeRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
