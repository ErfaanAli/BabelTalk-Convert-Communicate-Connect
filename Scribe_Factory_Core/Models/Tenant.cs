using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Scribe_Factory_Core.Models
{
	public class Tenant
	{
		public long Id { get; set; }
		public string Name { get; set; }
		public DateTime CreatedDate { get; set; }
		public bool IsActive { get; set; }

		public ICollection<Project> Projects { get; set; }
		public ICollection<Subcribers> Subcribers { get; set; }
		public ICollection<ApplicatioUser> ApplicatioUsers { get; set; }
	}
}
