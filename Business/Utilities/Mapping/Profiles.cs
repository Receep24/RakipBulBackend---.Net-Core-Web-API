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
        CreateMap<CreateAdressDto, Adress>();
        CreateMap<CreateAdvertDto, Advert>();
        CreateMap<CreateCitiesDto, Cities>();
        CreateMap<CreateCommentDto, Comment>();
        CreateMap<CreateDistrictsDto, User>();
        CreateMap<CreateEventDto, Events>();
        CreateMap<CreateOfferDto, Offer>();
        CreateMap<CreatePointDto, Point>();
        CreateMap<CreateSportsDto, Sports>();
        CreateMap<CreateUserEvent, UserEvents>();
       

        //update                                                         
        CreateMap<AdressUpdateDTO, Adress>();
        CreateMap<AdvertUpdateDTO, Advert>();
        CreateMap<CitiesUpdateDTO, Cities>();
        CreateMap<CommentUpdateDTO, Comment>();
        CreateMap<EventsUpdateDTO, Events>();
        CreateMap<OfferUpdateDTO, Offer>();
        CreateMap<PointUpdateDTO, Point>();
        CreateMap<SportsUpdateDTO, Sports>();
        CreateMap<UserEventUpdateDTO, UserEvents>();
        CreateMap<UserProfileUpdateDto, User>();
      


        //responsse                                                      
        CreateMap<Adress, AdressInfoDto>();
        CreateMap<Advert, AdvertInfoDto>();
        CreateMap<Cities, CitiesInfoDto>();
        CreateMap<Comment, CommentInfoDto>();
        CreateMap<Districts, DistrictsInfoDto>();
        CreateMap<Events, EventsInfoDto>();
        CreateMap<Offer, OfferInfoDto>();
        CreateMap<Point, PointInfoDto>();
        CreateMap<Sports, SportsInfoDto>();
        CreateMap<UserEvents, UserEventsInfoDto>();
        CreateMap<User, UserProfileDto>();

        CreateMap<PasswordChangeDTO, User>();

       

    }
}