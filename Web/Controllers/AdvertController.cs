using Business.Models.Request.Create;
using Business.Models.Request.Functional;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Web.Controllers.Base;

namespace Web.Controllers
{
    public class AdvertController : BaseCRUDController<Advert, int, CreateAdvertDto, UpdateAdvertDto, ShowAdvertsDto>
    {
        public AdvertController(IBaseService<Advert, ShowAdvertsDto, int> service) : base(service)
        {
        }
    }
}
