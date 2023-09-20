using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;

namespace Business.Utilities.Mapping;

public class Profiles : AutoMapper.Profile
{
    public Profiles()
    {
        //Create
        CreateMap<RegisterDto, User>();
        CreateMap<CreateAdressDto, User>();
        CreateMap<CreateAdvertDto, User>();
        CreateMap<CreateCitiesDto, User>();
        CreateMap<CreateCommentDto, User>();
        CreateMap<CreateDistrictsDto, User>();
        CreateMap<CreateEventDto, User>();
        CreateMap<CreateOfferDto, User>();
        CreateMap<CreatePointDto, User>();
        CreateMap<CreateSportsDto, User>();
        CreateMap<CreateUserEvent, User>();
       

        //update                                                         
        CreateMap<AdressUpdateDTO, User>();
        CreateMap<AdvertUpdateDTO, User>();
        CreateMap<CitiesUpdateDTO, User>();
        CreateMap<CommentUpdateDTO, User>();
        CreateMap<EventsUpdateDTO, User>();
        CreateMap<OfferUpdateDTO, User>();
        CreateMap<PointUpdateDTO, User>();
        CreateMap<SportsUpdateDTO, User>();
        CreateMap<UserEventUpdateDTO, User>();
        CreateMap<UserProfileUpdateDto, User>();
      


        //responsse                                                      
        CreateMap<User, AdressInfoDto>();
        CreateMap<User, AdvertInfoDto>();
        CreateMap<User, CitiesInfoDto>();
        CreateMap<User, CommentInfoDto>();
        CreateMap<User, DistrictsInfoDto>();
        CreateMap<User, EventsInfoDto>();
        CreateMap<User, OfferInfoDto>();
        CreateMap<User, PointInfoDto>();
        CreateMap<User, SportsInfoDto>();
        CreateMap<User, UserEventsInfoDto>();
        CreateMap<User, UserProfileDto>();



       

    }
}