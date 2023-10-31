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
        

        public async Task AddAsync(Events entity)
        {
            // DateTime özelliklerini UTC'ye dönüştür
            entity = ConvertDateTimePropertiesToUtc(entity);

            await PostgresContext.Set<Events>().AddAsync(entity);
        }

        private Events ConvertDateTimePropertiesToUtc(Events entity)
        {
            var properties = entity.GetType().GetProperties()
                .Where(prop => prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?));

            foreach (var property in properties)
            {
                var value = (DateTime?)property.GetValue(entity);
                if (value.HasValue)
                {
                    // Zaman dilimini UTC'ye dönüştür
                    property.SetValue(entity, value.Value.ToUniversalTime());
                }
            }

            return entity;
        }

        public Task<IList<Events>> GetByAdvertIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
