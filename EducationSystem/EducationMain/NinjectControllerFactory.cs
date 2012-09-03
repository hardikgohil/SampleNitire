using System;
using EducationDomain.Repository;
using Ninject;
using System.Web.Mvc;
using System.Web.Routing;
using EducationInterfaces;
using EducationDomain.Factory;
using EducationDomain.Services;


namespace EducationMain
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _ninjectkernel;

        public NinjectControllerFactory()
        {
            _ninjectkernel = new StandardKernel();
            AddBindings();
        }

        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null
                ? null
                : (IController)_ninjectkernel.Get(controllerType);
        }

        private void AddBindings()
        {
            //put additional bindings here
            _ninjectkernel.Bind<IStudentViewFactory>().To<StudentViewFactory>();
            _ninjectkernel.Bind<IStudentService>().To<StudentService>();
            _ninjectkernel.Bind<IStudentRepository>().To<StudentRepository>();

        }
    }
}