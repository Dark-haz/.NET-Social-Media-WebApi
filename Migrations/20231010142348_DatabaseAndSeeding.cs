using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class DatabaseAndSeeding : Migration
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
                    { 1, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(8220), "Voluptatum necessitatibus voluptatem saepe mollitia ea minima voluptas. Eum sit labore non. Culpa quae aut natus perferendis hic ex nisi distinctio quod. In a impedit eum eaque. Eos alias officiis eos eum accusantium libero delectus quasi praesentium.", "", "Doloremque sit temporibus quia.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(8520), "Eligendi ducimus repellat. Molestias sed voluptatem ipsum esse culpa placeat. At temporibus ea qui ex qui. Modi eligendi et aperiam sequi quibusdam.", "", "Aspernatur quod nesciunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(8640), "Assumenda similique sit quis et ipsum est beatae. Dolor qui laudantium quisquam.", "", "Voluptas enim cupiditate aut.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(8790), "Quis enim suscipit sunt. Minus soluta est perferendis molestias excepturi libero. Omnis quos aperiam ad in fugit omnis.", "", "Tempore doloribus ratione ad.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(9010), "Et dolores minus voluptates. Sequi recusandae nam dolorum dicta provident reprehenderit vitae. Natus praesentium assumenda pariatur et odio ut. Qui earum soluta.", "", "Eveniet tenetur non.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(9120), "Nisi omnis laudantium. Est atque minus vel rerum reiciendis laboriosam reprehenderit nihil.", "", "Blanditiis eum quaerat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(9390), "Autem impedit asperiores et. Facere quos quia porro beatae reprehenderit. Sunt numquam sequi dolores consectetur suscipit voluptates quam quis. Et qui ut a.", "", "Fuga voluptatem voluptatum dolor.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(9700), "Est quis aliquid enim ea qui molestias quaerat voluptas consequuntur. Quibusdam sed exercitationem voluptas rerum aperiam quis ab voluptas. Totam laboriosam dolore soluta est consequatur rerum explicabo magnam. Alias eos consequatur nesciunt. Consequatur dolorem voluptatem ut aut ad sapiente quo mollitia molestiae.", "", "Ab nobis quaerat.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2023, 10, 10, 17, 23, 48, 462, DateTimeKind.Local).AddTicks(9940), "Quo dolorem accusamus dolor. Illo ipsa repudiandae neque accusamus. Voluptates sapiente numquam deserunt sunt tempore quis. Sunt doloremque incidunt temporibus totam veritatis quia labore.", "", "Quo vitae blanditiis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(120), "Aperiam deleniti et molestias fugiat et. Hic explicabo possimus nemo et aut explicabo facilis.", "", "Libero quibusdam.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "CreatedDate", "Description", "PostID" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(450), "Nisi rerum nulla tempora eos officia. Et facere non atque vitae numquam. Et rem omnis nulla ipsum in.", 2 },
                    { 2, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(640), "Nihil doloremque sit ab hic sed sit hic. Est eos voluptate illo quae incidunt. Alias numquam quidem ab rerum. Esse officiis repellat doloribus vero.", 3 },
                    { 3, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(790), "Dolorem neque repellendus nemo iusto repellendus rerum asperiores suscipit. Dolor et nobis sed accusamus. Minima eius quia sed. Sit nemo saepe aperiam laborum ducimus qui.", 7 },
                    { 4, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(900), "Maiores quam eaque dolore maxime consequatur dolore sint id. Eius nihil sit et quisquam est numquam ad.", 4 },
                    { 5, new DateTime(2023, 10, 10, 17, 23, 48, 463, DateTimeKind.Local).AddTicks(1110), "Provident provident fugiat voluptatem est eaque aut maiores. Minus libero suscipit qui et nostrum fugiat ab eos omnis.", 9 }
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
                name: "Posts");
        }
    }
}
