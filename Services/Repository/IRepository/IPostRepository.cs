using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Social_Media_API.Models;
using Social_Media_API.Models.DTO;

namespace Social_Media_API.Services.Repository
{
    public interface IPostRepository
    {
        //> Store the needed functions to access database 
        //! Takes MODEL TYPE
                                        // Func<in,out>
        Task<List<Post>> GetAllAsync(Expression<Func<Post,bool>> filter = null); //if we need to filter it
        Task<Post> GetAsync(Expression<Func<Post,bool>> filter = null , bool tracked = true); 
        Task CreateAsync(Post entity); 
        Task UpdateAsync(Post entity); 
        Task RemoveAsync(Post entity);
        Task SaveAsync();
            
    }
}