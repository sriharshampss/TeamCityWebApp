using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Infrastructure;

namespace Flightglobal.JobManagement.Interfaces
{
	public interface IJobTypeInfrastructure : IOperationManager<JobType>
	{
		List<string> GetAllTypes();
	}
}
