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
        CreateMap<CreateCommentDto, User>();
        CreateMap<CreateEventDto, User>();
        CreateMap<CreateOfferDto, User>();

        //update                                                         
        CreateMap<UpdateAdressDto, User>();
        CreateMap<UpdateAdvertDto, User>();
        CreateMap<UpdateCommentDto, User>();
        CreateMap<UserProfileUpdateDto, User>();


        //responsse                                                      
        CreateMap<User, UserProfileDto>();
        CreateMap<User, UserAdvertsDto>();
        CreateMap<User, UserEventsDto>();
        CreateMap<User, ShowAdvertsDto>();
        CreateMap<User, ShowEventsDto>();
        CreateMap<User, ShowOfferDto>();


        //

    }
}