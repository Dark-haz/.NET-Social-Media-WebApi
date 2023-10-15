using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(type: "longtext", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    ImageUrl = table.Column<string>(type: "longtext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(type: "longtext", nullable: false),
                    Password = table.Column<string>(type: "longtext", nullable: false),
                    Role = table.Column<string>(type: "longtext", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(type: "longtext", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    PostID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Comments_Posts_PostID",
                        column: x => x.PostID,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySQL:Charset", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Title", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9080), "Corrupti distinctio quo qui non aut non velit cumque. Amet eos rerum nihil iste dolorem soluta ut. Minima reprehenderit quasi omnis ipsam ipsum et numquam vero aut. Veritatis temporibus in a repellendus maiores ut autem sint sunt. Dolores quia est esse vero excepturi.", "", "Sit quia illum.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9440), "Quas aut impedit dicta quam. Ut nihil id omnis soluta et nobis placeat velit voluptas. Voluptatem est sed repudiandae. Quam quia minima rerum aut sed qui architecto officia.", "", "Amet atque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9780), "Iusto aut dicta sed sit ipsum. Quae sunt laborum in voluptas et laborum sed odio. Ab ut non eum repudiandae. Autem fugiat similique quis molestias.", "", "Fuga voluptatibus qui sit.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9990), "Pariatur illo adipisci optio. Qui aut non. Excepturi dolor nihil. Necessitatibus aut cum culpa officia ipsam.", "", "Provident numquam ipsam sunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(330), "Distinctio officia accusantium nam aut et error amet qui voluptatem. Quo deleniti reiciendis dolorem molestiae eos reiciendis. Quia sapiente dolores.", "", "Est autem fugit eaque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(560), "Voluptas aliquid in fugiat consequatur nesciunt quia. Laudantium vel aut dicta eaque possimus. Assumenda eius et ratione illum ducimus recusandae.", "", "Ut ducimus.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(880), "Molestias impedit quia vero. Illo sit neque iure minima suscipit. Inventore repudiandae vel rem blanditiis et et. Aspernatur voluptate animi qui animi nesciunt quas voluptatem sed.", "", "Aliquam quibusdam ab.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1160), "Iste optio corporis sed. Architecto blanditiis nesciunt. Voluptatem nobis modi exercitationem consequatur autem blanditiis. Nostrum assumenda iure.", "", "Quidem dolores soluta.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1510), "Enim et eum distinctio ut. Vero qui sint fugit cum aut et esse inventore similique. Odit doloribus perspiciatis. Nobis et in autem maxime doloremque deserunt vero ut.", "", "Voluptas similique dolorem provident.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1740), "Qui nesciunt tempora aut sed magnam mollitia reiciendis. Porro animi quasi. Tempore illo maiores ut rerum itaque voluptatum officiis assumenda.", "", "Aperiam officia nemo.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "Username" },
                values: new object[,]
                {
                    { 1, "hello", "Admin", "Dio" },
                    { 2, "hi", "Normal", "Jotaro" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "Description", "PostID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2170), "Dolores vero sapiente quia et facere et magni sunt. Et dolorem delectus sit est.", 9 },
                    { 2, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2370), "Odio officiis quis earum voluptatibus et molestias occaecati quae. Illum adipisci enim velit illum reiciendis. Reiciendis recusandae error dolores modi.", 5 },
                    { 3, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2520), "Et libero fuga. Unde tempore labore enim dolorum et. Quod sunt illum velit harum.", 9 },
                    { 4, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2620), "Dolor consequuntur accusantium. Inventore iste sapiente occaecati sunt.", 6 },
                    { 5, new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2800), "Est qui natus exercitationem repellendus consequatur. Incidunt modi rerum.", 9 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_PostID",
                table: "Comments",
                column: "PostID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
