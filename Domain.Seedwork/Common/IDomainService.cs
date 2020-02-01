using Domain.Seedwork.Specification;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Seedwork.Common
{
    public interface IDomainService<TEntity> : IDisposable
        where TEntity : Entity
    {
        TEntity Add(TEntity item);

        IEnumerable<TEntity> Add(IEnumerable<TEntity> items);

        Task<TEntity> AddAsync(TEntity item);

        Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> items);

        void Remove(TEntity item);

        void Remove(object id);

        void Remove(IEnumerable<TEntity> items);

        void Remove(IEnumerable<object> ids);

        Task RemoveAsync(TEntity item);

        Task RemoveAsync(object id);

        Task RemoveAsync(IEnumerable<TEntity> items);

        Task RemoveAsync(IEnumerable<object> ids);

        TEntity Modify(TEntity item);

        IEnumerable<TEntity> Modify(IEnumerable<TEntity> items);

        TEntity Modify(object id, TEntity item);

        Task<TEntity> ModifyAsync(TEntity item);

        Task<IEnumerable<TEntity>> ModifyAsync(IEnumerable<TEntity> items);

        Task<TEntity> ModifyAsync(object id, TEntity item);

        void Refresh(TEntity item);

        TEntity Get(object id);

        Task<TEntity> GetAsync(object id);

        IEnumerable<TEntity> GetAll();

        Task<IEnumerable<TEntity>> GetAllAsync();

        IEnumerable<TEntity> AllMatching(ISpecification<TEntity> specification);

        Task<IEnumerable<TEntity>> AllMatchingAsync(ISpecification<TEntity> specification);

        IEnumerable<TEntity> AllMatching<KProperty>(ISpecification<TEntity> specification, int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);

        Task<IEnumerable<TEntity>> AllMatchingAsync<KProperty>(ISpecification<TEntity> specification, int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);

        TEntity FirstMatching(ISpecification<TEntity> specification);

        Task<TEntity> FirstMatchingAsync(ISpecification<TEntity> specification);

        IEnumerable<TEntity> GetPaged<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);

        Task<IEnumerable<TEntity>> GetPagedAsync<KProperty>(int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);

        IEnumerable<TEntity> GetFiltered(Expression<Func<TEntity, bool>> filter);

        Task<IEnumerable<TEntity>> GetFilteredAsync(Expression<Func<TEntity, bool>> filter);

        IEnumerable<TEntity> GetFiltered<KProperty>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);

        Task<IEnumerable<TEntity>> GetFilteredAsync<KProperty>(Expression<Func<TEntity, bool>> filter, int pageIndex, int pageCount, Expression<Func<TEntity, KProperty>> orderByExpression, bool ascending);
    }
}
