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
    public class AdressRepository : Repository<Adress, int>, IAdressRepository
    {
        public AdressRepository(PostgresContext postgresContext) : base(postgresContext)
        {
        }

        public async Task<IList<Adress>> GetAllAsync(Expression<Func<Adress, bool>>? filter = null)
        {
            var adresses = PostgresContext.Set<Adress>();
            return filter == null
                ? await adresses.ToListAsync()
                : await adresses.Where(filter)
                .ToListAsync();
        }

       
    }
}
