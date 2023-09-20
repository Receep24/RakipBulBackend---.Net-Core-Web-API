using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class DistrictsController : BaseCRUDController<Districts, int, CreateDistrictsDto, DistrictsUpdateDTO, DistrictsInfoDto>
    {
        public DistrictsController(IBaseService<Districts, DistrictsInfoDto, int> service) : base(service)
        {
        }
    }
}
