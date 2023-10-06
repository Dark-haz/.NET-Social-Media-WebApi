using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Data;
using Social_Media_API.Models;

namespace Social_Media_API.Services.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly AppDbContext _db;

        public PostRepository(AppDbContext db)
        {
            _db = db; //to talk with db
        }

        public async Task CreateAsync(Post entity)
        {
            await _db.Posts.AddAsync(entity);
            await SaveAsync();
        }

        

        public async Task<Post> GetAsync(Expression<Func<Post,bool>> filter = null, bool tracked = true)
        {
            IQueryable<Post> query = _db.Posts; //doesn't get executed right away , stores query
            if(!tracked){query.AsNoTracking();}
            if(filter != null) {query = query.Where(filter);} //optional filter (not so much)
            return await query.FirstOrDefaultAsync(); //executes
        }

        public async Task<List<Post>> GetAllAsync(Expression<Func<Post,bool>> filter = null)
        {
            IQueryable<Post> query = _db.Posts; //doesn't get executed right away , stores query

            if(filter != null) {query = query.Where(filter);} //optional filter
            return await query.ToListAsync(); //executes
        }

        public async Task RemoveAsync(Post entity)
        {
            _db.Posts.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

        public async Task UpdateAsync(Post entity)
        {
            _db.Update(entity);
            await SaveAsync();
        }
    }
}