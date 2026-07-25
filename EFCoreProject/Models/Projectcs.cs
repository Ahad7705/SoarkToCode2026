using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreProject.Models
{
    public class Projectcs
    {
        [Key]
        public int ProjectId { get; set; }

        public int ProjectNumber { get; set; }

        public string ProjectName { get; set; }

        public string ProjectLocation { get; set; }
    }
}
