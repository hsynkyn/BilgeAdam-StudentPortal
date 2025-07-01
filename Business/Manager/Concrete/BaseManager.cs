using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Manager.Interface;
using Core.Entities.Abstract;
using Core.Interface;
using DTO.Abstract;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Storage;

namespace Business.Manager.Concrete
{
    public abstract class BaseManager<A, C>(A service, IMapper mapper) : IBaseManager<A, C> 
        where A : IBaseRepository<C> 
        where C : BaseEntity
    {
        private readonly A _service = service;
        private readonly IMapper _mapper = mapper;

        public async Task<bool> AddAsync(BaseDTO dto)
        {
            var entity = _mapper.Map<C>(dto);
            return await _service.AddAsync(entity);
        }


        public async Task<bool> UpdateAsync(BaseDTO dto, Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return false;

            _mapper.Map(dto, entity);
            return await _service.UpdateAsync(entity);
        }

        public virtual async Task<bool> DeleteAsync(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return false;

            return await _service.DeleteAsync(entity);
        }

        public async Task<bool> AnyAsync(Expression<Func<C, bool>> expression)=>await _service.AnyAsync(expression);
               

        public async Task<List<T>> GetByDefaultsAsync<T>(Expression<Func<C, bool>> expression)
        {
            var entityList =  await _service.GetByDefaultsAsync(expression);
            var dtoList = _mapper.Map<List<T>>(entityList);

            return dtoList;
        }

        public async Task<T?> GetByDefaultAsync<T>(Expression<Func<C, bool>> expression, Func<IQueryable<C>, IIncludableQueryable<C, object>>? join = null)
        {
            var entity = await _service.GetByDefaultAsync(expression, join);
            var dto = _mapper.Map<T>(entity);

            return dto;
        }

        public async Task<T?> GetByIdAsync<T>(Guid id)
        {
            var entity = await _service.GetByIdAsync(id);
            if (entity == null)
                return default;
            
            var dto = _mapper.Map<T>(entity);
            return dto;
        }

        public async Task<List<TResult>> GetFilteredListAsync<TResult>(Expression<Func<C, TResult>> select, Expression<Func<C, bool>>? where = null, Func<IQueryable<C>, IOrderedQueryable<C>>? orderBy = null, Func<IQueryable<C>, IIncludableQueryable<C, object>>? join = null)
            => await _service.GetFilteredList(select, where, orderBy, join);

        public async Task<IDbContextTransaction> BeginTransactionAsync() => await _service.BeginTransactionAsync();

    }
}
