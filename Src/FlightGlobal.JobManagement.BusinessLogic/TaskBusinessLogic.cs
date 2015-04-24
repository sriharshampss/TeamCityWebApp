using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.Interfaces;

namespace FlightGlobal.JobManagement.BusinessLogic
{
	public class TaskBusinessLogic : ITaskBusiness
	{
		private ITaskInfrastructure taskRepository;
		private IJobTypeInfrastructure jobTypeRepository;
		private IJobInfrastructure jobRepository;


		public TaskBusinessLogic()
		{

		}


		public bool Create(Flightglobal.JobManagement.ServiceModels.TaskResponse obj)
		{
			throw new NotImplementedException();
		}

		public Flightglobal.JobManagement.ServiceModels.TaskResponse Retrieve(string key)
		{
			throw new NotImplementedException();
		}

		public bool Update(Flightglobal.JobManagement.ServiceModels.TaskResponse obj)
		{
			throw new NotImplementedException();
		}

		public bool Delete(string Key)
		{
			throw new NotImplementedException();
		}

		public List<Flightglobal.JobManagement.ServiceModels.TaskResponse> ListAll()
		{
			throw new NotImplementedException();
		}
	}
}
