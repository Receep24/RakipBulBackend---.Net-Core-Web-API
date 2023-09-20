using Infrastructure.Data.Postgres.Repositories.Interface;
using System.Collections.Generic;

namespace Infrastructure.Data.Postgres;

public interface IUnitOfWork : IDisposable
{
    IAdressRepository Adress { get; }
    IAdvertRepository Advert { get; }
    ICitiesRepository Cities { get; }
    ICommentRepository Comment { get; }

    IDistrictsRepository Districts { get; }
    IEventsRepository Events { get; }
    IOfferRepository Offer { get; }
    IPointRepository Point { get; }
    ISportsRepository Sports { get; }
    IUserRepository Users { get; }
    IUserEventsRepository UsersEvents { get; }
    IUserTokenRepository UserTokens { get; }

    Task<int> CommitAsync();
}
