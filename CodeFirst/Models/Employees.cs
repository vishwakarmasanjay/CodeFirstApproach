using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CFUsingEF.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Display(Name="Full Name")]
        [Required( ErrorMessage = "Full Name Required.")]
        public string Name { get; set; }

        [Display(Name = "Emaill Address")]
        [Required(ErrorMessage = "Email Address Required.")]
        [EmailAddress(ErrorMessage="Invalid Email Address.")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Mobile No.")]
        [Required(ErrorMessage = "Mobile No. Required.")]
        [StringLength(10, MinimumLength=10)]
        public string Mobile { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address Required.")]
        public string Address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City Required.")]
        public string City { get; set; }

        [Display(Name = "State")]
        [Required(ErrorMessage = "State Required.")]
        public string State { get; set; }

        [Display(Name = "Department Name")]
        public int? DepartmentId { get; set; }
        [ForeignKey("Department")]
        public virtual Department Departments { get; set; }
    }

    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }

        [Display(Name = "Department Name")]
        [Required(ErrorMessage = "Department Name Required.")]
        public string name { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }

    }
}