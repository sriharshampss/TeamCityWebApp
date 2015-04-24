using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flightglobal.JobManagement.Interfaces
{
    public interface IOperationManager<T>
    {
	    bool Create(T obj);

	    T Retrieve(string key);

	    bool Update(T obj);

	    bool Delete(string Key);

	    List<T> ListAll();

    }
}
