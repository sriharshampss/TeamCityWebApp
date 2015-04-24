using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;


namespace Flightglobal.JobManagement.Infrastructure
{
	public class JobTypeInfrastructureOperations : IJobTypeInfrastructure
	{


		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<string> GetAllTypes()
		{
			throw new NotImplementedException();
		}

		public bool Create(JobType obj)
		{
			throw new NotImplementedException();
		}

		JobType IOperationManager<JobType>.Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(JobType obj)
		{
			throw new NotImplementedException();
		}

		List<JobType> IOperationManager<JobType>.ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
