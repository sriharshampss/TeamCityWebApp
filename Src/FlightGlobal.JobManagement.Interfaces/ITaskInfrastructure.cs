using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using Task = Flightglobal.JobManagement.Infrastructure.Task;

namespace FlightGlobal.JobManagement.Interfaces
{
	public interface ITaskInfrastructure : IOperationManager<Task>
	{

	}
}
