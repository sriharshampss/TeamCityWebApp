using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Infrastructure;
using Flightglobal.JobManagement.Interfaces;

namespace FlightGlobal.JobManagement.Interfaces
{
	public interface IJobInfrastructure : IOperationManager<Job>
	{
		
	}
}
