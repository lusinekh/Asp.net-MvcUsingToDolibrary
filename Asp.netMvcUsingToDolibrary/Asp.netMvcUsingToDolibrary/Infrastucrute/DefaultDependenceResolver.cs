using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.netMvcUsingToDolibrary.Infrastucrute
{
    public class DefaultDependenceResolver : IDependencyResolver
    {
        IKernel kernel;

        public void AddBind()
        {


        }

        public object GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            throw new NotImplementedException();
        }
    }
}