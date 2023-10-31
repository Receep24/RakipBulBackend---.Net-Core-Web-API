using Business.Models.Response;
using Business.Services.Base;
using Business.Services.Interface;
using Business.Utilities.Mapping.Interface;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class DistrictsService : BaseService<Districts, DistrictsInfoDto, int>, IDistrictsService
    {
        private readonly IUnitOfWork _unitOfWork;
        public DistrictsService(IMapperHelper mapperHelper, IUnitOfWork unitOfWork) : base(mapperHelper, unitOfWork.Districts, unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IList<Districts> GetDistrictsByCityId(int cityId)
        {
            // Koddan bir şehir kimliği ile ilişkilendirilmiş ilçeleri sorgula ve döndür.
            return _unitOfWork.Districts.GetAllAsync(d => d.CityId == cityId).Result;
        }
    }
}
