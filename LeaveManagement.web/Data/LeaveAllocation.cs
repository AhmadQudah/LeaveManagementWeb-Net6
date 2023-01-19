using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagement.web.Data
{
    public class LeaveAllocation : BaseEntity
    {
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeTypeId { get; set; }

        public string EmployeeId { get; set; }

    }
}
