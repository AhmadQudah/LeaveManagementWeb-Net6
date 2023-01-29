using LeaveManagement.web.Contracts;
using LeaveManagement.Data;

namespace LeaveManagement.web.Repositories
{
    public class LeaveTypeRepository : GenericRepository<LeaveType>, ILeaveTypeRepository
    {
        public LeaveTypeRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
