using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedPostTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "CreatedDate", "Description", "ImageUrl", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sed molestiae eum libero dolore. Eos a nam magnam non asperiores magnam velit aut aperiam. Velit distinctio ut illo et minima. Sed asperiores qui consequatur aut vitae.", "", "Fugiat facilis omnis est." },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Explicabo recusandae perferendis rerum. Similique voluptatum id eos accusantium magni ut officia et reiciendis. Exercitationem eum quidem mollitia laudantium consequatur itaque. Ullam quidem rerum saepe quis.", "", "Autem aut at debitis." },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Consequatur reprehenderit consequatur perferendis tenetur. Error itaque occaecati hic quam ut velit iure est. Optio quia ipsam rem omnis beatae modi nisi. Dolorem ea et doloribus. Quo consequatur facilis rerum deserunt natus velit cum illum excepturi.", "", "Dolores commodi eaque." },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Commodi eum facere hic magni quia ut exercitationem quae modi. Necessitatibus minus aut optio magni optio. Et maxime omnis et id consequatur. Id est qui aliquam saepe qui.", "", "Quibusdam sint facere sed." },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Perspiciatis facilis amet. Similique veniam illo autem qui aut laboriosam asperiores rerum aut.", "", "Dolor iste quam aut." },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ut itaque ipsam amet nobis dolor sit eius cupiditate. Laudantium qui dolores. Modi molestiae iste voluptatem quam ut sint sunt.", "", "Dolor voluptates quae." },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alias repellat rerum et tempore praesentium optio. Occaecati debitis rerum consectetur amet cumque. Suscipit sit quis perspiciatis.", "", "Dolor nesciunt voluptatum." },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dicta sed iure fuga earum. Doloribus mollitia blanditiis hic molestias voluptas. Iure ab et sequi quis non enim debitis et. Iste quo praesentium aperiam aliquid dolore ut.", "", "Magni amet fugiat." },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Deserunt id iste omnis eum aspernatur. Quae necessitatibus non. Numquam quidem debitis numquam qui placeat unde consequatur et. Non est dolores quae et est. Nostrum natus alias et ipsam rerum occaecati ea sed.", "", "Occaecati ratione harum." },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Voluptatem placeat officia repellat et mollitia corrupti. A ut doloribus veritatis hic voluptatum. Praesentium quia maxime ad omnis quam vel adipisci animi. Odio quia expedita possimus. Dolores impedit architecto quasi non.", "", "Et natus est." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
