using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Social_Media_API.Models;
using Social_Media_API.Models.PostModels;
using Social_Media_API.Services.Repository.IRepository;

namespace Social_Media_API.Services.Repository
{
    public interface IPostRepository : IRepository<Post>
    {
        //> Store the needed functions to access database 
        //! Takes MODEL TYPE

        //_ MOVED TO GENERIC
                                        // Func<in,out>
        // _ Task<List<Post>> GetAllAsync(Expression<Func<Post,bool>> filter = null); //if we need to filter it
        //_ Task<Post> GetAsync(Expression<Func<Post,bool>> filter = null , bool tracked = true); 
        //_ Task CreateAsync(Post entity); 
        //_ Task RemoveAsync(Post entity);
        //_ Task SaveAsync();
        
        Task<Post> UpdateAsync(Post entity); 
            
    }
}