using AutoMapper;
using Business.Services.Base.Interface;
using Business.Utilities.Mapping.Interface;
using Core.Constants;
using Core.Results;
using Infrastructure.Data.Postgres;
using Infrastructure.Data.Postgres.Entities.Base;
using Infrastructure.Data.Postgres.Repositories.Base.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services.Base
{
    public abstract class BaseService<TEntity, TResponseDto, TId> : IBaseService<TEntity, TResponseDto, TId>
        where TEntity : class
        where TResponseDto : class
    {
        protected readonly IMapperHelper _mapperHelper;
        private readonly IRepository<TEntity, TId> _repository;
        protected readonly IUnitOfWork _unitOfWork;
        public BaseService(IMapperHelper mapperHelper, IRepository<TEntity, TId> repository, IUnitOfWork unitOfWork)
        {
            _mapperHelper = mapperHelper;
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public virtual async Task<Result> AddAsync(TEntity entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new Result(Messages.Success, ResultStatus.Ok);
        }

        public async Task<Result> AddFromDtoAsync(object entityDto)
        {
            TEntity entity = _mapperHelper.Map<TEntity>(entityDto);
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return new Result(Messages.Success, ResultStatus.Ok);
        }

        public async Task<Result> DeleteAsync(TId id)
        {
            await _repository.RemoveByIdAsync(id);
            await _unitOfWork.CommitAsync();
            return new Result(Messages.Success, ResultStatus.Ok);
        }

        public virtual async Task<DataResult<IList<TResponseDto>>> GetAllAsync()
        {
            IList<TEntity> entities = await _repository.GetAllAsync();
            IList<TResponseDto> mappedEntities = _mapperHelper.Map<IList<TResponseDto>>(entities);
            return new DataResult<IList<TResponseDto>>(mappedEntities);
        }

        public virtual async Task<DataResult<TResponseDto>> GetByIdAsync(TId id)
        {
            TEntity entity = await _repository.GetByIdAsync(id);
            TResponseDto mappedEntity = _mapperHelper.Map<TResponseDto>(entity);
            return new DataResult<TResponseDto>(mappedEntity);
        }

        public async Task<Result> UpdateAsync(TId id, object entityDTO)
        {
            TEntity entity = await _repository.GetByIdAsync(id);

            _mapperHelper.Map(entityDTO, entity);
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
            return new Result(Messages.Success, ResultStatus.Ok);
        }
    }
}
