using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Flightglobal.JobManagement.Infrastructure
{
    public class Job
    {
	    public int JobId { get; set; }

	    public string Name { get; set; }

	    public string Description { get; set; }

	    public string Notes { get; set; }

	    public int JobTypeId { get; set; }

	    public string Parameters { get; set; }

	    public string CreatedBy { get; set; }

	    public DateTime CreatedOn { get; set; }

	    public string LastUpdateBy { get; set; }

	    public DateTime LastUpdateOn { get; set; }

	    public bool IsActive { get; set; }


    }
}
