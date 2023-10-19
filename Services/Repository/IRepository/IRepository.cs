using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Social_Media_API.Services.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        Task<List<T>> GetAllAsync(Expression<Func<T,bool>> ? filter = null , string ? includeNavigation = null
        , int pageSize = 0 , int pageNumber = 1); //if we need to filter it
        Task<T> GetAsync(Expression<Func<T,bool>>  filter = null , bool tracked = true, string ? includeNavigations = null); 
        Task CreateAsync(T entity); 
        Task RemoveAsync(T entity);
        Task SaveAsync();
    }
}