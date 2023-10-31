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
    public class AdressController : BaseCRUDController<Adress, int, CreateAdressDto, AdressUpdateDTO, AdressInfoDto>
    {
        public AdressController(IAdressService service) : base(service)
        {
        }
    }
}
