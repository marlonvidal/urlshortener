using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UrlShortener.Model;

namespace UrlShortener.Data.Interfaces
{
    public interface IBaseRepository<T> where T : EntityBase
    {
        Task<T> GetById(int id);
        Task<T> Find(Expression<Func<T, bool>> where);
        Task<List<T>> FindAll(Expression<Func<T, bool>> where);
        Task<T> Add(T entity);
        Task<T> Update(T entity);
        Task Delete(T entity);
    }
}
