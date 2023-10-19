using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Models.PostModels;
using Bogus;
using Social_Media_API.Models.CommentModels;
using Social_Media_API.Models.UserModels;

namespace Social_Media_API.Data
{
    public class AppDbContext : DbContext
    {

        

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<User> Users { get; set; }

        //! SEEDING

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var faker = new Faker(); //faker

            //! SEED POSTS

            var postList = new List<Post> { }; //seed data list

            for (int i = 1; i <= 10; i++) //number of posts
            {
                var random = new Random(); //random numbers

                var fakepost = new Post
                { //create fake post
                    Id = i,

                    Title = faker.Lorem.Sentence(random.Next(2, 5)),
                    Description = faker.Lorem.Paragraph(random.Next(2, 3)),
                    ImageUrl = "",
                    CreatedDate = DateTime.Now
                };

                postList.Add(fakepost); //add post to seed list
            }

            modelBuilder.Entity<Post>().HasData( //insert to post table
                postList
            );

            //! SEED COMMENTS

            var commentList = new List<Comment> { }; //seed data list

            for (int i = 1; i <= 5; i++) //number of comments
            {
                var random = new Random(); //random numbers

                var fakecomment = new Comment
                { //create fake comment
                    Id = i,
                    Description = faker.Lorem.Paragraph(random.Next(2, 3)),
                    CreatedDate = DateTime.Now,
                    PostID = random.Next(1, 10),
                    Votes = random.Next(0,5)
                };

                commentList.Add(fakecomment); //add post to seed list
            }

            modelBuilder.Entity<Comment>().HasData( //insert to comment table
                commentList
            );

            //! SEED USER
            var addUser = new List<User>{
                new User{
                Id = 1,
                Username = "Dio",
                Password = "hello",
                Role = "Admin"
                },
                new User{
                Id = 2,
                Username = "Jotaro",
                Password = "hi",
                Role = "Normal"
                }
            };
            modelBuilder.Entity<User>().HasData(addUser);
        }
    }
}