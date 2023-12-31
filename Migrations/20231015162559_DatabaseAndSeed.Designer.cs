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
    [Migration("20231015162559_DatabaseAndSeed")]
    partial class DatabaseAndSeed
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Social_Media_API.Models.CommentModels.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("PostID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PostID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2170),
                            Description = "Dolores vero sapiente quia et facere et magni sunt. Et dolorem delectus sit est.",
                            PostID = 9
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2370),
                            Description = "Odio officiis quis earum voluptatibus et molestias occaecati quae. Illum adipisci enim velit illum reiciendis. Reiciendis recusandae error dolores modi.",
                            PostID = 5
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2520),
                            Description = "Et libero fuga. Unde tempore labore enim dolorum et. Quod sunt illum velit harum.",
                            PostID = 9
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2620),
                            Description = "Dolor consequuntur accusantium. Inventore iste sapiente occaecati sunt.",
                            PostID = 6
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2800),
                            Description = "Est qui natus exercitationem repellendus consequatur. Incidunt modi rerum.",
                            PostID = 9
                        });
                });

            modelBuilder.Entity("Social_Media_API.Models.PostModels.Post", b =>
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

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9080),
                            Description = "Corrupti distinctio quo qui non aut non velit cumque. Amet eos rerum nihil iste dolorem soluta ut. Minima reprehenderit quasi omnis ipsam ipsum et numquam vero aut. Veritatis temporibus in a repellendus maiores ut autem sint sunt. Dolores quia est esse vero excepturi.",
                            ImageUrl = "",
                            Title = "Sit quia illum.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9440),
                            Description = "Quas aut impedit dicta quam. Ut nihil id omnis soluta et nobis placeat velit voluptas. Voluptatem est sed repudiandae. Quam quia minima rerum aut sed qui architecto officia.",
                            ImageUrl = "",
                            Title = "Amet atque.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 3,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9780),
                            Description = "Iusto aut dicta sed sit ipsum. Quae sunt laborum in voluptas et laborum sed odio. Ab ut non eum repudiandae. Autem fugiat similique quis molestias.",
                            ImageUrl = "",
                            Title = "Fuga voluptatibus qui sit.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 4,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9990),
                            Description = "Pariatur illo adipisci optio. Qui aut non. Excepturi dolor nihil. Necessitatibus aut cum culpa officia ipsam.",
                            ImageUrl = "",
                            Title = "Provident numquam ipsam sunt.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 5,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(330),
                            Description = "Distinctio officia accusantium nam aut et error amet qui voluptatem. Quo deleniti reiciendis dolorem molestiae eos reiciendis. Quia sapiente dolores.",
                            ImageUrl = "",
                            Title = "Est autem fugit eaque.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 6,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(560),
                            Description = "Voluptas aliquid in fugiat consequatur nesciunt quia. Laudantium vel aut dicta eaque possimus. Assumenda eius et ratione illum ducimus recusandae.",
                            ImageUrl = "",
                            Title = "Ut ducimus.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 7,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(880),
                            Description = "Molestias impedit quia vero. Illo sit neque iure minima suscipit. Inventore repudiandae vel rem blanditiis et et. Aspernatur voluptate animi qui animi nesciunt quas voluptatem sed.",
                            ImageUrl = "",
                            Title = "Aliquam quibusdam ab.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 8,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1160),
                            Description = "Iste optio corporis sed. Architecto blanditiis nesciunt. Voluptatem nobis modi exercitationem consequatur autem blanditiis. Nostrum assumenda iure.",
                            ImageUrl = "",
                            Title = "Quidem dolores soluta.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 9,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1510),
                            Description = "Enim et eum distinctio ut. Vero qui sint fugit cum aut et esse inventore similique. Odit doloribus perspiciatis. Nobis et in autem maxime doloremque deserunt vero ut.",
                            ImageUrl = "",
                            Title = "Voluptas similique dolorem provident.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            Id = 10,
                            CreatedDate = new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1740),
                            Description = "Qui nesciunt tempora aut sed magnam mollitia reiciendis. Porro animi quasi. Tempore illo maiores ut rerum itaque voluptatum officiis assumenda.",
                            ImageUrl = "",
                            Title = "Aperiam officia nemo.",
                            UpdatedDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Social_Media_API.Models.UserModels.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Password = "hello",
                            Role = "Admin",
                            Username = "Dio"
                        },
                        new
                        {
                            Id = 2,
                            Password = "hi",
                            Role = "Normal",
                            Username = "Jotaro"
                        });
                });

            modelBuilder.Entity("Social_Media_API.Models.CommentModels.Comment", b =>
                {
                    b.HasOne("Social_Media_API.Models.PostModels.Post", "Post")
                        .WithMany()
                        .HasForeignKey("PostID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");
                });
#pragma warning restore 612, 618
        }
    }
}
