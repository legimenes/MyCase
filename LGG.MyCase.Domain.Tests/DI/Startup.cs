using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using Microsoft.Practices.Unity;
using System.Web.Http;

namespace LGG.MyCase.Domain.Tests.DI
{
    public class Startup
    {
        public static void Configuration(UnityContainer container)
        {
            var config = new HttpConfiguration();
            //var container = new UnityContainer();

            ConfigureDependencyInjection(config, container);
        }

        public static void ConfigureDependencyInjection(HttpConfiguration config, UnityContainer container)
        {
            DependencyResolver.Resolve(container);

            config.DependencyResolver = new UnityResolverHelper(container);
            DomainEvent.Container = new DomainEventsContainer(config.DependencyResolver);
        }
    }
}