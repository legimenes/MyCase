using LGG.MyCase.Domain.Contracts.Repositories;
using LGG.MyCase.Domain.Contracts.AppServices;
using LGG.MyCase.Domain.Entities;
using LGG.MyCase.SharedKernel.Interfaces.Transaction;
using LGG.MyCase.SharedKernel.Resources;
using System.Collections.Generic;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Events;
using LGG.MyCase.SharedKernel.DomainNotificationHelper;
using LGG.MyCase.Domain.Contracts.Services;

namespace LGG.MyCase.Application.Services
{
    public class GenreAppService : IGenreAppService
    {
        private readonly IHandler<DomainNotification> _notifications;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenreRepository _genreRepository;
        private readonly IGenreService _genreService;

        public GenreAppService(IUnitOfWork unitOfWork, IGenreRepository genreRepository, IGenreService genreService)
        {
            _notifications = DomainEvent.Container.GetService<IHandler<DomainNotification>>();
            _unitOfWork = unitOfWork;
            _genreRepository = genreRepository;
            _genreService = genreService;
        }

        public bool Save(Genre genre)
        {
            _genreService.Save(genre);

            if (!_notifications.HasNotifications())
                _unitOfWork.Commit();            

            return _notifications.HasNotifications();
        }
        
        public IEnumerable<Genre> GetGenres()
        {
            return _genreService.GetGenres();
        }

        /*
        public Genre GetGenre(int id)
        {
            Genre genre = _genreRepository.GetGenre(id);
            AssertionConcern.AssertArgumentNotNull(genre, Errors.GenreNotFound);

            return genre;
        }
        public void Delete(Genre genre)
        {
            Genre existingGenre = _genreRepository.GetGenre(genre.Id);
            AssertionConcern.AssertArgumentNotNull(existingGenre, Errors.GenreNotFound);

            _genreRepository.Delete(genre);
        }
        */
        public void Dispose()
        {
            _genreRepository.Dispose();
        }
    }
}