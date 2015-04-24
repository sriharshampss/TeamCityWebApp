using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.Interfaces;

namespace Flightglobal.JobManagement.Infrastructure
{
	public class JobInfrastructureOperations : IJobInfrastructure
	{
		public bool Create(Job obj)
		{
			throw new NotImplementedException();
		}

		public Job Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(Job obj)
		{
			throw new NotImplementedException();
		}

		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<Job> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
