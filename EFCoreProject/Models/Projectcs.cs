

using System.Collections.Generic;

namespace EFCoreProject.Models
{
    public class Project
    {
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        public string ProjectLocation { get; set; }
        // worksOn M-M
        public List<empProj> empProjs { get; set; }
    }
}