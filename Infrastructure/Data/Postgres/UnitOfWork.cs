using Core.Utilities;
using Infrastructure.Data.Postgres.Entities.Base.Interface;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data.Postgres;

public class UnitOfWork : IUnitOfWork
{
    private readonly PostgresContext _postgresContext;

    private AdressRepository _adressRepository;
    private AdvertRepository _advertRepositort;
    private CitiesRepository _citiesRepository;
    private CommentRepository _commentRepository;
    private DistrictsRepository _distritsRepository;
    private EventsRepository _eventsRepository;
    private OfferRepository _offerRepository;
    private PointRepository _pointRepository;
    private SportsRepository _sportRepository;
    private UserRepository? _userRepository;
    private UserEventsRepository? _userEventsRepository;
    private UserTokenRepository? _userTokenRepository;

    public UnitOfWork(PostgresContext postgresContext)
    {
        _postgresContext = postgresContext;
    }

    public IUserRepository Users => _userRepository ??= new UserRepository(_postgresContext);
    public IUserTokenRepository UserTokens => _userTokenRepository ??= new UserTokenRepository(_postgresContext);

    public IAdressRepository Adress =>_adressRepository ??= new AdressRepository(_postgresContext);

    public IAdvertRepository Advert => _advertRepositort ??= new AdvertRepository(_postgresContext);    

    public ICitiesRepository Cities =>_citiesRepository ??= new CitiesRepository(_postgresContext);

    public ICommentRepository Comment => _commentRepository ??= new CommentRepository(_postgresContext); 
    public IDistrictsRepository Districts => _distritsRepository ??= new DistrictsRepository(_postgresContext);

    public IEventsRepository Events => _eventsRepository ??= new EventsRepository(_postgresContext);    

    public IOfferRepository Offer => _offerRepository ??= new OfferRepository(_postgresContext);

    public IPointRepository Point => _pointRepository ??= new PointRepository(_postgresContext);    

    public ISportsRepository Sports => _sportRepository ??new SportsRepository(_postgresContext);
    public IUserEventsRepository UsersEvents => _userEventsRepository ?? new UserEventsRepository(_postgresContext);

    public async Task<int> CommitAsync()
    {
        var updatedEntities = _postgresContext.ChangeTracker.Entries<IEntity>()
            .Where(e => e.State == EntityState.Modified)
            .Select(e => e.Entity);

        foreach (var updatedEntity in updatedEntities)
        {
            updatedEntity.UpdatedAt = DateTime.UtcNow.ToTimeZone();
        }

        var result = await _postgresContext.SaveChangesAsync();

        return result;
    }

    public void Dispose()
    {
        _postgresContext.Dispose();
    }
}