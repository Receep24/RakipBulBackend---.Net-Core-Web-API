using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Web.Controllers;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class CitiesController : BaseCRUDController<Cities, int, CreateCitiesDto, CitiesUpdateDTO, CitiesInfoDto>
    {
        public CitiesController(ICitiesService service) : base(service)
        {
        }
    }
}

