using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.Contracts.Persistence;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagment.Persistence.Repositories
{
    public class LeaveRequestRepository : GenericRepository<LeaveRequest>,ILeaveRequestRepository
    {
        private readonly LeaveManagementDbContext _dbContext;
        public LeaveRequestRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task ChangeApprovalStatus(LeaveRequest leaveRequest, bool? approved)
        {
            leaveRequest.Approved = approved;
            _dbContext.Entry(leaveRequest).State = EntityState.Modified;
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<LeaveRequest>> GetLeaveRequestsWithDetails()
        {
            var leaveRequests = await _dbContext.LeaveRequests
                .Include(q => q.LeaveType)
                .ToListAsync();

            return leaveRequests;
        }

        public async Task<LeaveRequest> GetLeaveRequestWithDetails(int id)
        {
            var leaveRequest = await _dbContext.LeaveRequests
                 .Include(q => q.LeaveType)
                 .FirstOrDefaultAsync(q => q.Id == id);

            return leaveRequest;
        }

    }
}
