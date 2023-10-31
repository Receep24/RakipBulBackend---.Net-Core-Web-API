using Infrastructure.Data.Postgres.Entities;
using Infrastructure.Data.Postgres.EntityFramework;
using Infrastructure.Data.Postgres.Repositories.Base;
using Infrastructure.Data.Postgres.Repositories.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace Infrastructure.Data.Postgres.Repositories;

public class UserRepository : Repository<User, int>, IUserRepository
{
    public UserRepository(PostgresContext postgresContext) : base(postgresContext)
    {
    }

    public async Task<IList<User>> GetAllAsync(Expression<Func<User, bool>>? filter = null)
    {
        var query = PostgresContext.Set<User>();

        if (filter != null)
        {
            query = (DbSet<User>)query.Where(filter);
        }

        var users = await query
            .Include(u=>u.Comments)
            .ToListAsync();
        return users;
        
        
    }

    public Task<IList<User>> GetByUserIdAsync(int id)
    {
        throw new NotImplementedException();
    }
}