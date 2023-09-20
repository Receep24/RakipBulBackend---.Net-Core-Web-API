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
    public class AdvertService : BaseService<Advert, ShowAdvertsDto, int>,IAdvertService
    {
        public AdvertService(IMapperHelper mapperHelper, IRepository<Advert, int> repository, IUnitOfWork unitOfWork) : base(mapperHelper, repository, unitOfWork)
        {

        }
    }
}
