using FormBuddyWeb.Interfaces;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FormBuddyWeb.BusinessLogics
{
    public class FormBuddyDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public object Mock { get; private set; }

        public FormBuddyDependencyResolver(IKernel kernel)
        {
            this.kernel = kernel;
            AddBindings();
        }

        private void AddBindings()
        {
            kernel.Bind<IMiscRepository>().To<MiscAgent>();
            kernel.Bind<IUserRepository>().To<UserAgent>();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }
    }
}