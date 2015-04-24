using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlightGlobal.JobManagement.Interfaces;

namespace FlightGlobal.JobManagement.BusinessLogic
{
	public class JobBusinesLogic : IJobBusiness
	{
		public Flightglobal.JobManagement.ServiceModels.JobResponse GetJobByName(string name)
		{
			throw new NotImplementedException();
		}

		public bool Create(Flightglobal.JobManagement.ServiceModels.JobResponse obj)
		{
			throw new NotImplementedException();
		}

		public Flightglobal.JobManagement.ServiceModels.JobResponse Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(Flightglobal.JobManagement.ServiceModels.JobResponse obj)
		{
			throw new NotImplementedException();
		}

		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<Flightglobal.JobManagement.ServiceModels.JobResponse> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
