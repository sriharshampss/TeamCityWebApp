using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Flightglobal.JobManagement.BusinessLogic;
using Flightglobal.JobManagement.Infrastructure;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.BusinessLogic;
using FlightGlobal.JobManagement.Interfaces;
using Ninject.Modules;

namespace FlightGlobal.JobManagement.WebAPI.Controllers
{
	public class NinjectJobManagementModule : NinjectModule
	{

		public override void Load()
		{
			//Business logic binding
			Bind<ITaskBusiness>().To<TaskBusinessLogic>();
			Bind<IJobBusiness>().To<JobBusinesLogic>();
			Bind<IJobTypeBusiness>().To<JobTypeBusinessLogic>();

			//Infrastructure binding
			Bind<ITaskInfrastructure>().To<TaskInfrastructureOperations>();
			Bind<IJobTypeInfrastructure>().To<JobTypeInfrastructureOperations>();
			Bind<IJobInfrastructure>().To<JobInfrastructureOperations>();



		}
	}
}