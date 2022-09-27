using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribe_Factory_Core.Models
{
    public class Project
    {
        public int Id { get; set; }
        public long TenantId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectType { get; set; }
        public Tenant Tenant { get; set; }

        public ICollection<ProjectFiles> ProjectFiles { get; set; }
    }
}
