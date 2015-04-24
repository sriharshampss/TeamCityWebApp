using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dependencies;
using Ninject;
using Ninject.Syntax;

namespace Flightglobal.JobManagement.WebAPI.Controllers
{
	public class NinjectDependencyScope : IDependencyScope
	{
		IResolutionRoot resolver;

		public NinjectDependencyScope(IResolutionRoot resolver)
		{
			this.resolver = resolver;
		}

		public object GetService(Type serviceType)
		{
			if (resolver == null)
				throw new ObjectDisposedException("this", "This scope has been disposed");

			if (serviceType.IsSubclassOf(typeof(ApiController)))
			{
				return resolver.Get(serviceType);
			}

			return resolver.TryGet(serviceType);
		}

		public System.Collections.Generic.IEnumerable<object> GetServices(Type serviceType)
		{
			if (resolver == null)
				throw new ObjectDisposedException("this", "This scope has been disposed");

			return resolver.GetAll(serviceType);
		}

		public void Dispose()
		{
		}
	}

	// This class is the resolver, but it is also the global scope
	// so we derive from NinjectScope.
	public class NinjectDependencyResolver : NinjectDependencyScope, IDependencyResolver
	{
		readonly IKernel kernel;

		public NinjectDependencyResolver(IKernel kernel)
			: base(kernel)
		{
			this.kernel = kernel;
		}

		public IDependencyScope BeginScope()
		{
			return new NinjectDependencyScope(kernel);
		}
	}
}