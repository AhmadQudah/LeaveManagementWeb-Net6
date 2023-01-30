using LeaveManagement.Data;
using LeaveManagement.Common.Models;

namespace LeaveManagement.Application.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
         Task LeaveAllocation(int leaveTypeId);
         Task<bool> AllocationExists(string employeeId,int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string employeeId);
        Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocations(int id);
        Task<bool> UpdateEmployeeAllocations(EditLeaveAllocationVM model);
    }
}
