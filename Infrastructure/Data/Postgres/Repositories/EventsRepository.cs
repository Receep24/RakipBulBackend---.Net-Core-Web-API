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
    public class EventsRepository : Repository<Events, int>, IEventsRepository
    {
        public EventsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Events>> GetAllAsync(Expression<Func<Events, bool>>? filter = null)
        {
            IQueryable<Events> advertQuery = PostgresContext.Set<Events>();

            if (filter != null)
            {
                advertQuery = advertQuery.Where(filter);
            }

            var events = await advertQuery
                .Include(r => r.Sports)
                .Include(r => r.Adress)
                .Include(r => r.UserEvents)
                .Include(r => r.Adress.District)
                .Include(r => r.Adress.City)
                .ToListAsync();

            return events;



        }
        public Task<IList<Events>> GetByAdvertIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
