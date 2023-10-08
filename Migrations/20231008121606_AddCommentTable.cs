using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

#nullable disable

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class AddCommentTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Posts",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

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

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(1450), "Aperiam debitis consectetur consequatur ullam ea labore libero et inventore. Suscipit nobis est animi. Blanditiis saepe modi voluptatem atque et quo sed. Facilis eveniet cum rerum earum voluptate omnis non accusantium.", "Eos veniam distinctio sunt.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(1860), "Ut facere voluptas. Veniam voluptates id nesciunt rem non iure aut tenetur. Qui in vel consequuntur at. Consequatur quam repudiandae illo velit qui a sed expedita. Aliquam rerum amet sit nostrum et qui culpa nulla.", "Maiores facilis et exercitationem.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(2000), "Voluptates id et voluptatibus est voluptatem. Eos laudantium qui dolorum ad quo.", "Quasi velit soluta.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(2290), "Voluptatem ullam ut debitis recusandae tempore ipsum repellendus saepe nisi. Est autem saepe maxime et molestiae autem debitis. Sit illum minima et. Corrupti minus aut ut beatae repellat.", "Itaque ut delectus ea.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(2590), "Aliquid molestias quis rerum. Minus quae mollitia natus sint quis ipsam. Qui voluptate maiores voluptas. Quam occaecati voluptas necessitatibus quasi eveniet quo dolorem. Molestias possimus explicabo tenetur veritatis fugiat dolorem voluptate et.", "Provident et quasi.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(2850), "Qui quasi voluptate totam facere voluptatem numquam quas. At culpa quisquam necessitatibus eligendi dolor. Distinctio dolore et et molestias cumque est nobis. Magnam autem accusantium sequi ea eos similique. Alias facilis placeat.", "Fugiat velit dolore.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(3090), "Quia molestiae repellendus voluptates. Magni laboriosam quia quam eligendi. Enim esse quasi odit maiores facere. Assumenda quis expedita reiciendis nihil aliquid.", "Ut pariatur.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(3230), "Nisi sit voluptatem accusamus et ut repudiandae dolorum voluptas. Omnis suscipit enim sed facilis quibusdam fugit itaque.", "Et dolores eaque.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(3450), "Exercitationem magni dicta minus fugiat qui quibusdam. Assumenda nobis aut ipsa. Quia officiis eum quam qui consequatur eligendi aspernatur.", "Ratione non dolores.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title", "UpdatedDate" },
                values: new object[] { new DateTime(2023, 10, 8, 15, 16, 6, 522, DateTimeKind.Local).AddTicks(3630), "Provident velit consequuntur architecto consectetur veniam totam labore molestias sed. Quo voluptatum et et. Mollitia dolor enim facere qui aliquid.", "Molestias eligendi et omnis.", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Posts");

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(4850), "Velit in inventore commodi dolor dolores minus. Dolores quasi et dolore error eos rerum culpa commodi eos. Placeat at ut occaecati non.", "Rerum error." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(5230), "Unde eius sit nisi. Rerum qui eum quam animi unde. Laboriosam totam aliquid sed quis adipisci omnis est odit.", "Voluptatem exercitationem asperiores." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(5770), "Voluptatibus ut sunt quos beatae modi. Et ducimus dolores quis voluptas corrupti doloribus pariatur commodi dolores. Dolorem ut consequuntur. Corporis pariatur quibusdam iure sint. Perspiciatis et quaerat sint sunt dolorum quis ex rerum culpa.", "Reprehenderit quibusdam ut nulla." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(6020), "Non laborum consequuntur atque minus ut nihil hic quia repellat. Non dolores consequuntur ea maxime qui recusandae.", "In vero soluta harum." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(6350), "Assumenda quia cumque et sequi quia qui id at. Sunt voluptatem dolorem natus doloribus voluptatem molestias.", "Qui commodi voluptatem molestiae." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(6640), "Culpa sed numquam provident est quia deserunt officiis ab. Magni doloribus illo eos voluptatem. Quis commodi ipsam at illo.", "Non rerum corrupti." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(7150), "Dicta facere nostrum at sequi sequi est. Unde velit facere quia tempore repellat molestiae iusto sit error. Excepturi vero fugiat quia accusantium nostrum reiciendis earum cum. Expedita qui cum culpa deserunt repellat quo nisi fuga.", "Facilis beatae id." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(7600), "Beatae eum autem repellendus et quo quis. Qui itaque itaque voluptas repellat consectetur et et. Exercitationem quam voluptas quibusdam et. Velit quia omnis.", "At voluptatum fugit." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(8110), "Eum est qui. Officiis enim nisi asperiores temporibus quia deserunt quod vitae sunt. Ut impedit non omnis qui nisi sed consequuntur. Voluptatem fugiat a. Sit velit quibusdam quasi similique voluptas libero et consequatur.", "Asperiores aperiam." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 5, 1, 41, 21, 408, DateTimeKind.Local).AddTicks(8680), "Ducimus qui alias et. Quaerat facilis maxime earum est suscipit est error quia voluptate. Rerum ut cum et harum aspernatur distinctio sequi. Accusantium in autem at incidunt ex.", "Eius enim ratione." });
        }
    }
}
