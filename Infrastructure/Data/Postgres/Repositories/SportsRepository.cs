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
    public class SportsRepository : Repository<Sports, int>, ISportsRepository
    {
        public SportsRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }
        public async Task<IList<Sports>> GetAllAsync(Expression<Func<Sports, bool>>? filter = null)
        {
            var sports = PostgresContext.Set<Sports>();
            return filter == null
                ? await sports.ToListAsync()
                : await sports.Where(filter)
                .ToListAsync();
        }
    }
}
