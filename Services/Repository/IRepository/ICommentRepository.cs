using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Social_Media_API.Models.CommentModels;

namespace Social_Media_API.Services.Repository.IRepository
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<Comment> UpdateAsync(Comment entity);
    }
}