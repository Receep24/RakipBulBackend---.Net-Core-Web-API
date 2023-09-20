using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class CitiesController : BaseCRUDController<Cities, int, CreateCitiesDto, CitiesUpdateDTO, CitiesInfoDto>
    {
        public CitiesController(IBaseService<Cities, CitiesInfoDto, int> service) : base(service)
        {
        }
    }
}

