using Core.Results;
using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base.Interface
{
    public interface IBaseService<TEntity, TResponseDto, TId>
     where TResponseDto : class
     where TEntity : class

    {
        Task<DataResult<TResponseDto>> GetByIdAsync(TId id);
        Task<DataResult<IList<TResponseDto>>> GetAllAsync();
        Task<Result> AddAsync(TEntity entity);
        Task<Result> AddFromDtoAsync(object entityDto);
        Task<Result> UpdateAsync(TId id, object entityDTO);
        Task<Result> DeleteAsync(TId id);
    }
}
