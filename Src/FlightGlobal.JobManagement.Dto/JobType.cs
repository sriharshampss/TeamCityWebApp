using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightglobal.JobManagement.Infrastructure
{
	public class JobType
	{
		public string JobTypeId { get; set; }

		public string  Name { get; set; }

		public string Description { get; set; }

		public string ECLScriptReference { get; set; }

		public string ParameterTemplate { get; set; }

		public bool IsActive { get; set; }
	}

	// 1 Carrier carrierjob "hpcc -carrier" "<xml></xml>" active
	// 1 Carrier carrierjob "hpcc -carrier" "<xml></xml>" active
	// 1 Carrier carrierjob "hpcc -carrier" "<xml></xml>" active
	// 1 Carrier carrierjob "hpcc -carrier" "<xml></xml>" active
	// 1 Carrier carrierjob "hpcc -carrier" "<xml></xml>" active
}
