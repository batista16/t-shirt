using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using tshirt.BusinessManagers.Tshirt;

namespace tshirt.Web.IoC
{
    public class BusinessManagersInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<ITshitBusinessManager>()
                .ImplementedBy<TshirtBusinessManager>()
                .LifestyleSingleton());
        }
    }
}