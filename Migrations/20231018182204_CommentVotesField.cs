using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Social_Media_API.Migrations
{
    /// <inheritdoc />
    public partial class CommentVotesField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Votes",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Votes" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(2820), "Quibusdam totam suscipit. Vel quo aliquid sint in autem. Non nisi autem voluptatem dolorem. Quia quia molestiae aut voluptate modi dolorum. Delectus et asperiores.", 1 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "PostID", "Votes" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(2970), "Sunt nihil est sit modi. Quis quae at eligendi.", 2, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "PostID", "Votes" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(3220), "Numquam enim aperiam omnis fuga quaerat repudiandae. Non perspiciatis quae culpa illo.", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "PostID", "Votes" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(3410), "Et ducimus nemo dicta veniam repellendus sunt inventore quia quasi. Repudiandae quas distinctio adipisci.", 4, 3 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Votes" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(3560), "Neque quia earum perferendis enim dolorem. Numquam in suscipit.", 2 });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 455, DateTimeKind.Local).AddTicks(8920), "Quia natus et soluta maiores temporibus. Quidem cupiditate eum dicta velit tempora consequuntur id. Officiis qui dolorem voluptatem qui quidem et.", "Voluptatem autem itaque." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 455, DateTimeKind.Local).AddTicks(9300), "Natus libero ab porro est. Officiis dolores numquam est.", "Doloribus odio non aut." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 455, DateTimeKind.Local).AddTicks(9680), "Cum ipsa et eveniet et. Dicta adipisci est in voluptatem deleniti illo vitae non ut. Sint voluptates qui consectetur quia rerum eaque voluptas cumque sit. Quos maiores et aut asperiores libero quas.", "Iusto quidem nihil." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(60), "Omnis repellat iusto eum consectetur totam rerum dicta quis pariatur. Aut culpa fuga. Id delectus autem et in exercitationem distinctio atque rerum.", "Molestiae maxime amet." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(330), "Quia autem ex ipsa vel qui iste dolores illo nisi. Earum corporis labore labore. Enim assumenda reiciendis mollitia esse reprehenderit.", "Dignissimos consequatur odit." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(860), "Et nostrum quia dolores corrupti vel pariatur non. Qui facere qui quos vitae ipsum beatae qui. Voluptas similique quia animi eaque ullam aspernatur. Eaque voluptatem iusto beatae veniam nam facilis fugit accusantium. Nobis autem autem in est qui optio.", "Consequuntur ex qui in." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(1160), "Rerum qui dolorem voluptatem non. Tenetur ipsum est aut dolorum eius fuga. Est ut sunt aut. Dolorem quis consequatur ut harum magnam.", "Impedit cum sequi qui." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(1620), "Reiciendis magnam minus libero et nobis a numquam natus. Minima facilis voluptatibus accusantium non officia. Consequatur dolor assumenda a. Occaecati et vel quidem.", "Illo necessitatibus." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(1920), "Et inventore excepturi. Omnis optio molestias enim. Ea ut soluta error et.", "Voluptatibus debitis." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 18, 21, 22, 4, 456, DateTimeKind.Local).AddTicks(2250), "Ex nostrum voluptatibus voluptas fugiat. Quod doloribus debitis aperiam nemo eum ex.", "Ullam non rerum." });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Votes",
                table: "Comments");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2170), "Dolores vero sapiente quia et facere et magni sunt. Et dolorem delectus sit est." });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "PostID" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2370), "Odio officiis quis earum voluptatibus et molestias occaecati quae. Illum adipisci enim velit illum reiciendis. Reiciendis recusandae error dolores modi.", 5 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "PostID" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2520), "Et libero fuga. Unde tempore labore enim dolorum et. Quod sunt illum velit harum.", 9 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "PostID" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2620), "Dolor consequuntur accusantium. Inventore iste sapiente occaecati sunt.", 6 });

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(2800), "Est qui natus exercitationem repellendus consequatur. Incidunt modi rerum." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9080), "Corrupti distinctio quo qui non aut non velit cumque. Amet eos rerum nihil iste dolorem soluta ut. Minima reprehenderit quasi omnis ipsam ipsum et numquam vero aut. Veritatis temporibus in a repellendus maiores ut autem sint sunt. Dolores quia est esse vero excepturi.", "Sit quia illum." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9440), "Quas aut impedit dicta quam. Ut nihil id omnis soluta et nobis placeat velit voluptas. Voluptatem est sed repudiandae. Quam quia minima rerum aut sed qui architecto officia.", "Amet atque." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9780), "Iusto aut dicta sed sit ipsum. Quae sunt laborum in voluptas et laborum sed odio. Ab ut non eum repudiandae. Autem fugiat similique quis molestias.", "Fuga voluptatibus qui sit." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 33, DateTimeKind.Local).AddTicks(9990), "Pariatur illo adipisci optio. Qui aut non. Excepturi dolor nihil. Necessitatibus aut cum culpa officia ipsam.", "Provident numquam ipsam sunt." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(330), "Distinctio officia accusantium nam aut et error amet qui voluptatem. Quo deleniti reiciendis dolorem molestiae eos reiciendis. Quia sapiente dolores.", "Est autem fugit eaque." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(560), "Voluptas aliquid in fugiat consequatur nesciunt quia. Laudantium vel aut dicta eaque possimus. Assumenda eius et ratione illum ducimus recusandae.", "Ut ducimus." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(880), "Molestias impedit quia vero. Illo sit neque iure minima suscipit. Inventore repudiandae vel rem blanditiis et et. Aspernatur voluptate animi qui animi nesciunt quas voluptatem sed.", "Aliquam quibusdam ab." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1160), "Iste optio corporis sed. Architecto blanditiis nesciunt. Voluptatem nobis modi exercitationem consequatur autem blanditiis. Nostrum assumenda iure.", "Quidem dolores soluta." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1510), "Enim et eum distinctio ut. Vero qui sint fugit cum aut et esse inventore similique. Odit doloribus perspiciatis. Nobis et in autem maxime doloremque deserunt vero ut.", "Voluptas similique dolorem provident." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Title" },
                values: new object[] { new DateTime(2023, 10, 15, 19, 25, 59, 34, DateTimeKind.Local).AddTicks(1740), "Qui nesciunt tempora aut sed magnam mollitia reiciendis. Porro animi quasi. Tempore illo maiores ut rerum itaque voluptatum officiis assumenda.", "Aperiam officia nemo." });
        }
    }
}
