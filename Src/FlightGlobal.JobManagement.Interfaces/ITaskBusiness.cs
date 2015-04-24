using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using Flightglobal.JobManagement.ServiceModels;

namespace FlightGlobal.JobManagement.Interfaces
{
	public interface ITaskBusiness : IOperationManager<TaskResponse>
	{
	}
}
