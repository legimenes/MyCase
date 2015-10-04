﻿using LGG.MyCase.Domain.Interfaces.Repositories;
using LGG.MyCase.Domain.Interfaces.Services;
using LGG.MyCase.Domain.Entities;
using LGG.MyCase.SharedKernel.Interfaces.Transaction;
using LGG.MyCase.SharedKernel.Resources;
using LGG.MyCase.SharedKernel.Validation;
using System.Collections.Generic;

namespace LGG.MyCase.Application.Services
{
    public class GenreService : IGenreService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGenreRepository _genreRepository;

        public GenreService(IUnitOfWork unitOfWork, IGenreRepository genreRepository)
        {
            _unitOfWork = unitOfWork;
            _genreRepository = genreRepository;
        }

        public IEnumerable<Genre> GetGenres()
        {
            return _genreRepository.GetGenres();
        }
        public Genre GetGenre(int id)
        {
            Genre genre = _genreRepository.GetGenre(id);
            AssertionConcern.AssertArgumentNotNull(genre, Errors.GenreNotFound);

            return genre;
        }
        public void Save(Genre genre)
        {
            genre.Validate();

            bool hasGenre = _genreRepository.GenreExists(genre.Id, genre.Description);
            AssertionConcern.AssertArgumentFalse(hasGenre, Errors.GenreDescriptionExists);

            if (genre.Id == 0)
                _genreRepository.Create(genre);
            else
                _genreRepository.Update(genre);

            _unitOfWork.Commit();
        }
        public void Delete(Genre genre)
        {
            Genre existingGenre = _genreRepository.GetGenre(genre.Id);
            AssertionConcern.AssertArgumentNotNull(existingGenre, Errors.GenreNotFound);

            _genreRepository.Delete(genre);
        }
        public void Dispose()
        {
            _genreRepository.Dispose();
        }
    }
}