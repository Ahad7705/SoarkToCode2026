using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreProject.Models
{
    public class empProj
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("emp")]
        public int EmployeeId { get; set; }

        public Employee emp { get; set; }

        [ForeignKey("proj")]
        public int ProjectId { get; set; }

        public Project proj { get; set; }

        public int Hours { get; set; }
    }
}