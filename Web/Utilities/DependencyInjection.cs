using Business.Models.Response;
using Business.Services;
using Business.Services.Base;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Business.Utilities.Mapping;
using Business.Utilities.Mapping.Interface;
using Business.Utilities.Security.Auth.Jwt;
using Business.Utilities.Security.Auth.Jwt.Interface;
using Business.Utilities.Validation;
using Business.Utilities.Validation.Interface;
using Core.Utilities.Mail;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;

namespace Web.Utilities;

public static class DependencyInjection
{
    public static void AddMyScoped(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddScoped<IUnitOfWork, UnitOfWork>();
        serviceCollection.AddScoped<IClaimHelper, ClaimHelper>();
        serviceCollection.AddScoped<IAuthService, AuthService>();
        serviceCollection.AddScoped<IAdressService, AdressService>();
        serviceCollection.AddScoped<IAdvertService, AdvertService>();
        serviceCollection.AddScoped<ICitiesService, CitiesService>();
        serviceCollection.AddScoped<ICommentService, CommentService>();
        serviceCollection.AddScoped<IDistrictsService, DistrictsService>();
        serviceCollection.AddScoped<IEventService, EventService>();
        serviceCollection.AddScoped<IOfferService, OfferService>();
        serviceCollection.AddScoped<IPointService, PointService>();
        serviceCollection.AddScoped<IProfileService, UserService>();
        serviceCollection.AddScoped<ISportsService, SportsService>();
        serviceCollection.AddScoped<IUserEventsService, UserEventsService>();
    }

    public static void AddMySingleton(this IServiceCollection serviceCollection)
    {
        serviceCollection.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        serviceCollection.AddSingleton<IMapperHelper, MapperHelper>();
        serviceCollection.AddSingleton<IValidationHelper, ValidationHelper>();
        serviceCollection.AddSingleton<IJwtTokenHelper, JwtTokenHelper>();
        serviceCollection.AddSingleton<IHashingHelper, HashingHelper>();
        serviceCollection.AddSingleton<IMailHelper, MailHelper>();
    }

    public static void AddMyTransient(this IServiceCollection serviceCollection) { }
}
