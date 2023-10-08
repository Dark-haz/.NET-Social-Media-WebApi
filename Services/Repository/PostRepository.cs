using Social_Media_API.Data;
using Social_Media_API.Models.PostModels;


namespace Social_Media_API.Services.Repository
{
    public class PostRepository : Repository<Post> , IPostRepository
    {
        private readonly AppDbContext _db;

        public PostRepository(AppDbContext db) : base(db)
        {
            _db = db; //to talk with db
        }


        public async Task<Post> UpdateAsync(Post entity)
        {
            entity.UpdatedDate = DateTime.Now; //different update than generic
            _db.Posts.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}