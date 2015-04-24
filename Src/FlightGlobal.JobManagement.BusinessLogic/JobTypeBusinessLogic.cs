using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.Interfaces;

namespace Flightglobal.JobManagement.BusinessLogic
{
	public class JobTypeBusinessLogic : IJobTypeBusiness
    {
	    public JobTypeBusinessLogic()
	    {


	    }

	    public bool Create(ServiceModels.JobTypeResponse obj)
		{
			throw new NotImplementedException();
		}

		public ServiceModels.JobTypeResponse Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(ServiceModels.JobTypeResponse obj)
		{
			throw new NotImplementedException();
		}

		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<ServiceModels.JobTypeResponse> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
