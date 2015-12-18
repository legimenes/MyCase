using LGG.MyCase.Application.Services;
using LGG.MyCase.Domain.Contracts.AppServices;
using LGG.MyCase.Domain.Contracts.Repositories;
using LGG.MyCase.Domain.Contracts.Services;
using LGG.MyCase.Domain.Services;
using LGG.MyCase.Infra.Data.Context;
using LGG.MyCase.Infra.Data.EntityFramework.Repositories;
using LGG.MyCase.Infra.Data.Transaction;
using LGG.MyCase.SharedKernel.DomainNotificationHelper;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Handlers;
using LGG.MyCase.SharedKernel.Interfaces.Transaction;
using Microsoft.Practices.Unity;

namespace LGG.MyCase.Domain.Tests.DI
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<IGenreService, GenreService>(new HierarchicalLifetimeManager());
            container.RegisterType<IHandler<DomainNotification>, DomainNotificationHandler>(new HierarchicalLifetimeManager());

            //Para o AppService
            container.RegisterType<MyCaseContext, MyCaseContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenreRepository, GenreRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenreAppService, GenreAppService>(new HierarchicalLifetimeManager());
        }
    }
}