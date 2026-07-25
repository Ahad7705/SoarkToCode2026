using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }

        public int DepartmentNumber { get; set; }

        public string DepartmentName { get; set; }

        public int NumberOfEmployees { get; set; }
    }
}
