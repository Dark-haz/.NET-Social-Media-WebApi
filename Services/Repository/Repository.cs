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
            // _db.Comments.Include(u=>u.Post).ToList(); //! navigation property automatically populated
        }

        public async Task CreateAsync(T entity)
        {
            await dbSet.AddAsync(entity);
            await SaveAsync();
        }

        public async Task<T> GetAsync(Expression<Func<T, bool>> filter = null, bool tracked = true, string? includeNavigations = null)
        {
            IQueryable<T> query = dbSet; //doesn't get executed right away , stores query
            if (!tracked) { query.AsNoTracking(); }
            if (filter != null) { query = query.Where(filter); } //optional filter (not so much)
            if (includeNavigations != null)
            {
                //split
                foreach (var includeNavigation in includeNavigations.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeNavigation); //include navigation individuallys
                }
            }
            return await query.FirstOrDefaultAsync(); //executes
        }

        //! comma separated string for navigation properties to be included
        public async Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, string? includeNavigations = null)
        {
            IQueryable<T> query = dbSet; //doesn't get executed right away , stores query

            if (filter != null) { query = query.Where(filter); } //optional filter

            if (includeNavigations != null)
            {
                //split
                foreach (var includeNavigation in includeNavigations.Split(',', StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(includeNavigation); //include navigation individuallys
                }
            }

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