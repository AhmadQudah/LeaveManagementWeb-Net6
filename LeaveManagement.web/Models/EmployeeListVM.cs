﻿using System.ComponentModel.DataAnnotations;

namespace LeaveManagement.web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }

        [Display(Name="First Name")]
        public string Firstname { get; set; }
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }        
        [Display(Name = "Date Joined")]
        public string DateOfJoin { get; set; }
        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}