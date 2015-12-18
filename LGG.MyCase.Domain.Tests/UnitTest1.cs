using LGG.MyCase.Domain.Contracts.AppServices;
using LGG.MyCase.Domain.Contracts.Repositories;
using LGG.MyCase.Domain.Contracts.Services;
using LGG.MyCase.Domain.Entities;
using LGG.MyCase.SharedKernel.DomainNotificationHelper;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using Microsoft.Practices.Unity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        public Database.FakeDB FakeDB;
        public readonly IGenreRepository MockGenreRepository;

        public UnitTest1()
        {
            FakeDB = new Database.FakeDB();

            Mock<IGenreRepository> mockGenreRepository = new Mock<IGenreRepository>();
            mockGenreRepository.Setup(mr => mr.GetGenres()).Returns(FakeDB.Genres);
            mockGenreRepository.Setup(mr => mr.Create(It.IsAny<Genre>())).Returns(
                (Genre target) =>
                {
                    target.Id = FakeDB.Genres.Count + 1;
                    FakeDB.Genres.Add(target);
                    return true;
                }
            );
            this.MockGenreRepository = mockGenreRepository.Object;
        }

        [TestMethod]
        [TestCategory("Geral")]
        public void TestMethod1()
        {
            var container = new UnityContainer();
            DI.Startup.Configuration(container);
            IHandler<DomainNotification> notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();

            Genre genre = new Genre()
            {
                Id = 0,
                Description = "Axé"
            };

            container.RegisterInstance<IGenreRepository>(this.MockGenreRepository);
            IGenreService genreService = container.Resolve<IGenreService>();
            genreService.Save(genre);

            IEnumerable<Genre> genres = genreService.GetGenres();

            if (notifications.HasNotifications())
            {
            }
            else
            {
            }
        }

        [TestMethod]
        public void TestFull()
        {
            var container = new UnityContainer();
            DI.Startup.Configuration(container);
            IHandler<DomainNotification> notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();

            Genre genre = new Genre()
            {
                Id = 0,
                Description = "Rock"
            };

            IGenreAppService service = container.Resolve<IGenreAppService>();
            service.Save(genre);

            if (notifications.HasNotifications())
            {
            }
            else
            {
            }
        }
    }
}