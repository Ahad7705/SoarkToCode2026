using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreProject.Models
{
    public class Dependent
    {
        public int DependentId { get; set; }

        public string DependentName { get; set; }

        [ForeignKey("emp")]
        public int EmployeeId { get; set; }

        public Employee emp { get; set; }
    }
}