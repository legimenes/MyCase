using LGG.MyCase.Domain.Contracts.Services;
using LGG.MyCase.Domain.Services;
using LGG.MyCase.SharedKernel.DomainNotificationHelper;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Handlers;
using Microsoft.Practices.Unity;

namespace LGG.MyCase.Domain.Tests.DI
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<IGenreService, GenreService>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());
        }
    }
}