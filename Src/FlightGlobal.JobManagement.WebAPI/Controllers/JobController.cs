using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Flightglobal.JobManagement.ServiceModels;


namespace Flightglobal.JobManagement.WebAPI.Controllers
{
	//http://hpccjobmanagementapi.flightglobaldev.rbidev.ds/api/Job/GetAllJobs
	//http://hpccjobmanagementapi.flightglobaldev.rbidev.ds/api/Job/CreateNewJob
	// ------>  JobController.cs

	//http://  dns  / api / {{entity }} / {{ action }} 

	public class JobController : ApiController
	{
		// GET api/values
		public List<JobResponse> Get()
		{
			return null;
		}

		// GET api/values/5
		public string Get(int id)
		{
			return "value";
		}

		[HttpPost]
		public void PoCreateNewJobst([FromBody]string value)
		{
		}

		[HttpPost]
		public void UpdateThisJob(int id, [FromBody]string value)
		{
		}

		[HttpPost]
		public void DeleteThisJob(int id)
		{
		}
	}
}