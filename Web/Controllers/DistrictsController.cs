using Business.Models.Request.Create;
using Business.Models.Request.Update;
using Business.Models.Response;
using Business.Services;
using Business.Services.Base.Interface;
using Business.Services.Interface;
using Infrastructure.Data.Postgres.Entities;
using Microsoft.AspNetCore.Mvc;
using Web.Controllers.Base;


namespace Web.Controllers
{
    public class DistrictsController : BaseCRUDController<Districts, int, CreateDistrictsDto, DistrictsUpdateDTO, DistrictsInfoDto>
    {
        private readonly IDistrictsService _service;
        public DistrictsController(IDistrictsService service) : base(service)
        {
            _service = service;
        }
        [HttpGet("bycity/{cityId}")]
        public IActionResult GetDistrictsByCityId(int cityId)
        {
            try
            {
                var districts = _service.GetDistrictsByCityId(cityId);
                return Ok(districts);
            }
            catch (Exception ex)
            {
                // Hata işleme burada yapılabilir.
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
