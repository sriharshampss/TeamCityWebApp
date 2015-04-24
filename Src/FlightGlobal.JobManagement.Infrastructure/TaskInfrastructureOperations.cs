using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.Interfaces;

namespace Flightglobal.JobManagement.Infrastructure
{
	public class TaskInfrastructureOperations : ITaskInfrastructure
	{
		public bool Create(Task obj)
		{
			throw new NotImplementedException();
		}

		public Task Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(Task obj)
		{
			throw new NotImplementedException();
		}

		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<Task> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
