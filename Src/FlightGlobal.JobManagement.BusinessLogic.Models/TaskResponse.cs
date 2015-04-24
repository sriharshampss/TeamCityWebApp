using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightglobal.JobManagement.ServiceModels
{
	public class TaskResponse
	{
		//[key]
		public int TaskId { get; set; }

		public int	JobId { get; set; }

		//DateTime when task was created. Used for prioritization.
		public DateTime CreatedDateTime { get; set; }

		// pending, in progress, complete, abort_pending, abort_in_progress, aborted.
		public string State { get; set; }

		//success, aborted, couldn’t connect to Thor, etc..
		public string Result { get; set; }

		// IP Address or other.
		public string HPCC_Cluster { get; set; }

		public string HPCC_WUID { get; set; }

		public string HPCC_StartDateTime { get; set; }

		public string HPCC_EndDateTime { get; set; }

		//Workunit_Information – information output from the ECL Workunit, e.g warnings.
		public string HPCC_Information { get; set; }

	}
}
