using LGG.MyCase.Domain.Entities;
using LGG.MyCase.SharedKernel.DomainNotificationHelper.Validation;
using LGG.MyCase.SharedKernel.Resources;

namespace LGG.MyCase.Domain.Scopes
{
    public static class GenreScopes
    {
        public static bool SaveScopeIsValid(this Genre genre)
        {
            return AssertionConcern.IsSatisfiedBy
            (
                AssertionConcern.AssertNotEmpty(genre.Description, Errors.EmptyGenreDescription)
            );
        }
    }
}