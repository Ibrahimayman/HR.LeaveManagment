using System;
using System.Collections.Generic;
using System.Text;
using HR.LeaveManagment.Domain;
using HR.LeaveManagment.Application.Contracts.Persistence;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HR.LeaveManagment.Persistence.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation> , ILeaveAllocationRepository
    {
        private readonly LeaveManagementDbContext _dbContext;
        public LeaveAllocationRepository(LeaveManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAllocations(List<LeaveAllocation> leaveAllocations)
        {
           await _dbContext.AddRangeAsync(leaveAllocations);
           await _dbContext.SaveChangesAsync();
        }

        public async Task<bool> AllocationExists(int userId, int leaveTypeId, int period)
        {
            return await
                _dbContext.LeaveAllocations.AnyAsync(
                    q => q.EmployeeId == userId &&
                    q.LeaveTypeId == leaveTypeId &&
                    q.Period == period);
        }

        public async Task<List<LeaveAllocation>> GetLeaveAllocationsWithDetails()
        {
            var leaveAllocations = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType)
                .ToListAsync();

            return leaveAllocations;
        }

        public async Task<LeaveAllocation> GetLeaveAllocationWithDetails(int Id)
        {
            var leaveAllocation = await _dbContext.LeaveAllocations
                .Include(q => q.LeaveType)
                .FirstOrDefaultAsync(q => q.Id == Id);

            return leaveAllocation;
        }

    }
}
