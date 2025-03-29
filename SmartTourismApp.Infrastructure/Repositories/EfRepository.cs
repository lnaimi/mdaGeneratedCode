
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using SmartTourismApp.SharedKernel.Interfaces;
using SmartTourismApp.SharedKernel;
using SmartTourismApp.Infrastructure;
using SmartTourismApp.Infrastructure.Specifications;

namespace SmartTourismApp.Infrastructure.Repositories
{
    public class EfRepository<T> : IAsyncRepository<T>, IRepository<T> where T : BaseEntity, IAggregateRoot
    {
        protected readonly SmartTourismAppContext _SmartTourismAppContext;

        public EfRepository(SmartTourismAppContext smartTourismAppContext)
        {
            _SmartTourismAppContext = smartTourismAppContext;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _SmartTourismAppContext.Set<T>().AddAsync(entity);
            await _SmartTourismAppContext.SaveChangesAsync();
            return entity;

        }

        public T Add(T entity)
        {
            _SmartTourismAppContext.Set<T>().Add(entity);
            _SmartTourismAppContext.SaveChanges();
            return entity;

        }

        public async Task UpdateAsync(T entity)
        {
            _SmartTourismAppContext.Entry(entity).State = EntityState.Modified;
            await _SmartTourismAppContext.SaveChangesAsync();
        }

        public int Update(T entity)
        {
            _SmartTourismAppContext.Entry(entity).State = EntityState.Modified;
            return _SmartTourismAppContext.SaveChanges();
        }

        public async Task DeleteAsync(T entity)
        {
            _SmartTourismAppContext.Set<T>().Remove(entity);
            await _SmartTourismAppContext.SaveChangesAsync();
        }

        public int Delete(T entity)
        {
            _SmartTourismAppContext.Set<T>().Remove(entity);
            return _SmartTourismAppContext.SaveChanges();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _SmartTourismAppContext.Set<T>().FindAsync(id);
        }

        public T GetById(int id)
        {
            return _SmartTourismAppContext.Set<T>().Find(id);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _SmartTourismAppContext.Set<T>().ToListAsync();
        }

        public IReadOnlyList<T> ListAll()
        {
            return _SmartTourismAppContext.Set<T>().ToList();
        }

        public async Task<IReadOnlyList<T>> ListAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).ToListAsync();
        }

        public IReadOnlyList<T> List(ISpecification<T> spec)
        {
            return ApplySpecification(spec).ToList();
        }


        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_SmartTourismAppContext.Set<T>().AsQueryable(), spec);
        }

        public async Task<int> CountAsync(ISpecification<T> spec)
        {
            return await ApplySpecification(spec).CountAsync();
        }

        public int Count(ISpecification<T> spec)
        {
            return ApplySpecification(spec).Count();
        }

    }
}

        