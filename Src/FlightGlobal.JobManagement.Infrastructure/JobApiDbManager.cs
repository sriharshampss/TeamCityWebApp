using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Flightglobal.JobManagement.Infrastructure;
using Flightglobal.JobManagement.Interfaces;
using FlightGlobal.JobManagement.Interfaces;

namespace Flightglobal.JobManagement.Infrastructure
{
	public class JobApiDbManager 
	{
		private ITaskInfrastructure taskRepository;
		private IJobTypeInfrastructure jobTypeRepository;
		private IJobInfrastructure jobRepository;

		public JobApiDbManager(ITaskInfrastructure taskRepository, IJobTypeInfrastructure jobTypeRepository, IJobInfrastructure jobRepository)
		{
			this.jobRepository = jobRepository;
			this.taskRepository = taskRepository;
			this.jobTypeRepository = jobTypeRepository;
			//Database.SetInitializer<JobManagementDbManager>(null);
		}

		//public bool GetAllTasksWith()
		//{

		//}

		#region notrequired
		//public JobManagementDbManager()
		//	: base("Name=JobsInformationconnection")
		//{
		//	Configuration.ProxyCreationEnabled = false;
		//}

		
		//public JobManagementDbManager(string connectionString)
		//	: base(connectionString)
		//{
		//	Configuration.ProxyCreationEnabled = false;
		//}

		
		//public JobManagementDbManager(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
		//	: base(connectionString, model)
		//{
		//	Configuration.ProxyCreationEnabled = false;
		//}

		
		//protected override void OnModelCreating(DbModelBuilder modelBuilder)
		//{
		//	base.OnModelCreating(modelBuilder);

		//}

		//public static DbModelBuilder CreateModel(DbModelBuilder modelBuilder, string schema)
		//{

		//	return modelBuilder;
		//}



		//public void Dispose()
		//{
		//	throw new NotImplementedException();
		//}

		#endregion
	}
}
