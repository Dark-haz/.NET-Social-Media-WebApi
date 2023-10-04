using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPostTableWithDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed molestiae eum libero dolore. Eos a nam magnam non asperiores magnam velit aut aperiam. Velit distinctio ut illo et minima. Sed asperiores qui consequatur aut vitae.", "Fugiat facilis omnis est." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo recusandae perferendis rerum. Similique voluptatum id eos accusantium magni ut officia et reiciendis. Exercitationem eum quidem mollitia laudantium consequatur itaque. Ullam quidem rerum saepe quis.", "Autem aut at debitis." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur reprehenderit consequatur perferendis tenetur. Error itaque occaecati hic quam ut velit iure est. Optio quia ipsam rem omnis beatae modi nisi. Dolorem ea et doloribus. Quo consequatur facilis rerum deserunt natus velit cum illum excepturi.", "Dolores commodi eaque." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi eum facere hic magni quia ut exercitationem quae modi. Necessitatibus minus aut optio magni optio. Et maxime omnis et id consequatur. Id est qui aliquam saepe qui.", "Quibusdam sint facere sed." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perspiciatis facilis amet. Similique veniam illo autem qui aut laboriosam asperiores rerum aut.", "Dolor iste quam aut." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut itaque ipsam amet nobis dolor sit eius cupiditate. Laudantium qui dolores. Modi molestiae iste voluptatem quam ut sint sunt.", "Dolor voluptates quae." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias repellat rerum et tempore praesentium optio. Occaecati debitis rerum consectetur amet cumque. Suscipit sit quis perspiciatis.", "Dolor nesciunt voluptatum." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dicta sed iure fuga earum. Doloribus mollitia blanditiis hic molestias voluptas. Iure ab et sequi quis non enim debitis et. Iste quo praesentium aperiam aliquid dolore ut.", "Magni amet fugiat." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt id iste omnis eum aspernatur. Quae necessitatibus non. Numquam quidem debitis numquam qui placeat unde consequatur et. Non est dolores quae et est. Nostrum natus alias et ipsam rerum occaecati ea sed.", "Occaecati ratione harum." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem placeat officia repellat et mollitia corrupti. A ut doloribus veritatis hic voluptatum. Praesentium quia maxime ad omnis quam vel adipisci animi. Odio quia expedita possimus. Dolores impedit architecto quasi non.", "Et natus est." });
        }
    }
}
