using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Social_Media_API.Data;
using Social_Media_API.Models.CommentModels;
using Social_Media_API.Services.Repository.IRepository;

namespace Social_Media_API.Services.Repository
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private readonly AppDbContext _db;
        public CommentRepository(AppDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Comment> UpdateAsync(Comment entity)
        {
            entity.CreatedDate = DateTime.Now;
            _db.Comments.Update(entity);
            await SaveAsync();
            return entity;
        }
    }
}