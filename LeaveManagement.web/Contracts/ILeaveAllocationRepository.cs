using LeaveManagement.web.Data;
using LeaveManagement.web.Models;

namespace LeaveManagement.web.Contracts
{
    public interface ILeaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
         Task LeaveAllocation(int leaveTypeId);
         Task<bool> AllocationExists(string employeeId,int leaveTypeId, int period);
        Task<EmployeeAllocationVM> GetEmployeeAllocation(string employeeId);
        Task<EditLeaveAllocationVM> GetEmployeeAllocations(int id);
        Task<bool> UpdateEmployeeAllocations(EditLeaveAllocationVM model);
    }
}
