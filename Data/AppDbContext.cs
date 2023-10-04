using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Social_Media_API.Models;
using Bogus;

namespace Social_Media_API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Post> Posts { get; set; }

        //! SEEDING
        
        protected override void  OnModelCreating(ModelBuilder modelBuilder){
            var faker = new Faker(); //faker

            var postList = new List<Post>{}; //seed data list

            for (int i = 1; i <= 10; i++) //number of posts
            {
                var random = new Random(); //random numbers

                var fakepost = new Post{ //create fake post
                    Id = i,
                    Title = faker.Lorem.Sentence(random.Next(2,5)),
                    Description = faker.Lorem.Paragraph(random.Next(2,3)),
                    ImageUrl = "",
                    CreatedDate = DateTime.Now
                }; 

                postList.Add(fakepost); //add post to seed list
            }

            modelBuilder.Entity<Post>().HasData( //insert to post table
                postList
            );
        }
    }
}