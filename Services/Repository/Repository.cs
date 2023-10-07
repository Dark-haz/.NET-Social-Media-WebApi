using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Data;
using Social_Media_API.Services.Repository.IRepository;

namespace Social_Media_API.Services.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _db;
        internal DbSet<T> dbSet;

        public Repository(AppDbContext db)
        {
            _db = db; //to talk with db
            this.dbSet = _db.Set<T>();
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T,bool>> filter = null, bool tracked = true)
        {
            IQueryable<T> query = dbSet; //doesn't get executed right away , stores query
            if(!tracked){query.AsNoTracking();}
            if(filter != null) {query = query.Where(filter);} //optional filter (not so much)
            return await query.FirstOrDefaultAsync(); //executes
        }

        public async Task<List<T>> GetAllAsync(Expression<Func<T,bool>> ? filter = null)
        {
            IQueryable<T> query = dbSet; //doesn't get executed right away , stores query

            if(filter != null) {query = query.Where(filter);} //optional filter
            return await query.ToListAsync(); //executes
        }

        public async Task RemoveAsync(T entity)
        {
            dbSet.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync()
        {
            await _db.SaveChangesAsync();
        }

    }
}