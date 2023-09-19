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

    public class EventController : BaseCRUDController<Events, int, CreateEventDto, UpdateEventDto, ShowEventsDto>
    {
        public EventController(IBaseService<Events, ShowEventsDto, int> service) : base(service)
        {
        }
    }
}
