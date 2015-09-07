using LGG.MyCase.Application.Services;
using LGG.MyCase.Domain.Interfaces.Repositories;
using LGG.MyCase.Domain.Interfaces.Services;
using LGG.MyCase.Infra.Data.ORM.Context;
using LGG.MyCase.Infra.Data.ORM.EntityFramework.Repositories;
using LGG.MyCase.Infra.Data.Transaction;
using LGG.MyCase.SharedKernel.Interfaces.Transaction;
using Microsoft.Practices.Unity;

namespace LGG.MyCase.CrossCutting.DI
{
    public class DependencyResolver
    {
        public static void Resolve(UnityContainer container)
        {
            container.RegisterType<MyCaseContext, MyCaseContext>(new HierarchicalLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenreRepository, GenreRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IGenreService, GenreService>(new HierarchicalLifetimeManager());
        }
    }
}