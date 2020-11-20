using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Data.Context;
using UrlShortener.Data.Interfaces;
using UrlShortener.Model;

namespace UrlShortener.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : EntityBase
    {
        private readonly UrlShortenerDbContext _dbContext;

        public BaseRepository(UrlShortenerDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<T> Add(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> Update(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public Task<T> Find(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().Where(where).FirstOrDefaultAsync();
        }

        public Task<List<T>> FindAll(Expression<Func<T, bool>> where)
        {
            return _dbContext.Set<T>().Where(where).ToListAsync();
        }

        public Task<T> GetById(int id)
        {
            return _dbContext.Set<T>().Where(x => x.ID == id).FirstOrDefaultAsync();
        }
    }
}
