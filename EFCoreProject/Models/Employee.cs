using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public int EmployeeSsn { get; set; }

        public string Employeename { get; set; }

        public string EmployeeMinit { get; set; }

        public string EmployeeLname { get; set; }

        public string EmployeeAddress { get; set; }

        public string EmployeeSex { get; set; }

        public DateTime EmployeeBdate { get; set; }

        public double EmployeeSalary { get; set; }
    }
}

