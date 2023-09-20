using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;
using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Infrastructure.Data.Postgres.Entities;
using Business.Services.Base.Interface;

namespace Web.Controllers
{

    public class EventController : BaseCRUDController<Events, int, CreateEventDto, EventsUpdateDTO, EventsInfoDto>
    {
        public EventController(IBaseService<Events, EventsInfoDto, int> service) : base(service)
        {
        }
    }
}
