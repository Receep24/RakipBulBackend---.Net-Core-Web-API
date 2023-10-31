using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Repositories
{
    public class DistrictsRepository : Repository<Districts, int>, IDistrictsRepository
    {
        public DistrictsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Districts>> GetAllAsync(Expression<Func<Districts, bool>>? filter = null)
        {
            IQueryable<Districts> districtQuery = PostgresContext.Set<Districts>();



            if (filter != null)
            {
                districtQuery = districtQuery.Where(filter);
            }

            var districts = await districtQuery
                .Include(d => d.City) // Include the City navigation property
                .ToListAsync();

            // You can now access the CityName property of the related City for each District
            foreach (var district in districts)
            {
                string cityName = district.City?.CityName; // Access CityName here
            }

            return districts;
        }
        public IList<Districts> GetDistrictsByCityId(int cityId)
        {
            // Koddan bir şehir kimliği ile ilişkilendirilmiş ilçeleri sorgula ve döndür.
            return PostgresContext.Districts.Where(d => d.CityId == cityId).ToList();
        }


    }
}
