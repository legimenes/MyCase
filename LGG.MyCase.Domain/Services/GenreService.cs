using LGG.MyCase.Domain.Entities;
using LGG.MyCase.Domain.Contracts.Repositories;
using LGG.MyCase.Domain.Contracts.Services;
using LGG.MyCase.SharedKernel.DomainNotificationHelper;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using System.Collections.Generic;

namespace LGG.MyCase.Domain.Services
{
    public class GenreService : IGenreService
    {
        private readonly IHandler<DomainNotification> _notification;
        private readonly IGenreRepository _genreRepository;

        public GenreService(IGenreRepository genreRepository)
        {
            _notification = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _genreRepository = genreRepository;
        }

        public bool Save(Genre genre)
        {
            genre.Save();

            if (!_notification.HasNotifications())
            {
                if (genre.Id == 0)
                    _genreRepository.Create(genre);
                else
                    _genreRepository.Update(genre);
            }

            return _notification.HasNotifications();
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _genreRepository.GetGenres();
        }

        public void Dispose()
        {
            _genreRepository.Dispose();
        }
    }
}