﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Social_Media_API.Data;

#nullable disable

namespace Social_Media_API.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20231004223720_SeedPostTable")]
    partial class SeedPostTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Social_Media_API.Models.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Sed molestiae eum libero dolore. Eos a nam magnam non asperiores magnam velit aut aperiam. Velit distinctio ut illo et minima. Sed asperiores qui consequatur aut vitae.",
                            ImageUrl = "",
                            Title = "Fugiat facilis omnis est."
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Explicabo recusandae perferendis rerum. Similique voluptatum id eos accusantium magni ut officia et reiciendis. Exercitationem eum quidem mollitia laudantium consequatur itaque. Ullam quidem rerum saepe quis.",
                            ImageUrl = "",
                            Title = "Autem aut at debitis."
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Consequatur reprehenderit consequatur perferendis tenetur. Error itaque occaecati hic quam ut velit iure est. Optio quia ipsam rem omnis beatae modi nisi. Dolorem ea et doloribus. Quo consequatur facilis rerum deserunt natus velit cum illum excepturi.",
                            ImageUrl = "",
                            Title = "Dolores commodi eaque."
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Commodi eum facere hic magni quia ut exercitationem quae modi. Necessitatibus minus aut optio magni optio. Et maxime omnis et id consequatur. Id est qui aliquam saepe qui.",
                            ImageUrl = "",
                            Title = "Quibusdam sint facere sed."
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Perspiciatis facilis amet. Similique veniam illo autem qui aut laboriosam asperiores rerum aut.",
                            ImageUrl = "",
                            Title = "Dolor iste quam aut."
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Ut itaque ipsam amet nobis dolor sit eius cupiditate. Laudantium qui dolores. Modi molestiae iste voluptatem quam ut sint sunt.",
                            ImageUrl = "",
                            Title = "Dolor voluptates quae."
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Alias repellat rerum et tempore praesentium optio. Occaecati debitis rerum consectetur amet cumque. Suscipit sit quis perspiciatis.",
                            ImageUrl = "",
                            Title = "Dolor nesciunt voluptatum."
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Dicta sed iure fuga earum. Doloribus mollitia blanditiis hic molestias voluptas. Iure ab et sequi quis non enim debitis et. Iste quo praesentium aperiam aliquid dolore ut.",
                            ImageUrl = "",
                            Title = "Magni amet fugiat."
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Deserunt id iste omnis eum aspernatur. Quae necessitatibus non. Numquam quidem debitis numquam qui placeat unde consequatur et. Non est dolores quae et est. Nostrum natus alias et ipsam rerum occaecati ea sed.",
                            ImageUrl = "",
                            Title = "Occaecati ratione harum."
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Description = "Voluptatem placeat officia repellat et mollitia corrupti. A ut doloribus veritatis hic voluptatum. Praesentium quia maxime ad omnis quam vel adipisci animi. Odio quia expedita possimus. Dolores impedit architecto quasi non.",
                            ImageUrl = "",
                            Title = "Et natus est."
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
