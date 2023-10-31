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
    public class AdvertRepository : Repository<Advert, int>, IAdvertRepository
    {
        public AdvertRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Advert>> GetAllAsync(Expression<Func<Advert, bool>>? filter = null)
        {
            IQueryable<Advert> advertQuery = PostgresContext.Set<Advert>();

            if (filter != null)
            {
                advertQuery = advertQuery.Where(filter);
            }

            var adverts = await advertQuery
                .Include(r => r.User)
                .Include(r => r.Sport)
                .Include(r => r.Adress)
                .Include(r => r.Adress.District)
                .Include(r => r.Adress.City)
                .ToListAsync();

            return adverts;
        }
        public Task<IList<Advert>> GetByAdvertIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
