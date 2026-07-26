using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public int DepartmentNumber { get; set; }

        public string DepartmentName { get; set; }


        // worksfor

        [InverseProperty("D")]
        public List<Employee> Employees { get; set; }


        // manage

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }
    }
}