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
    public class UserEventsRepository : Repository<UserEvents, int>, IUserEventsRepository
    {
        public UserEventsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<UserEvents>> GetAllAsync(Expression<Func<UserEvents, bool>>? filter = null)
        {
            IQueryable<UserEvents> advertQuery = PostgresContext.Set<UserEvents>();

            if (filter != null)
            {
                advertQuery = advertQuery.Where(filter);
            }

            var events = await advertQuery
                .Include(r => r.User)
                .Include(r => r.Events)  
                .Include(r=>r.Events.Adress)
                .Include(r=>r.Events.Sports)
                .Include(r=>r.Events.Adress.City)
                .Include(r=>r.Events.Adress.District)
                .ToListAsync();

            return events;
        }

       
    }
}
