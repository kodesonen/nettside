using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class kurskatalog : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1e8c3185-8baf-4020-9efe-3cbb892012d7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23c06d69-c85e-486a-9a1b-ea47d9f96bc8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba49b1f1-6266-400f-9a3b-0c7292cc84f8");

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a010b8a-0994-4268-a567-796eba45de0b", 0, null, "edd9121c-878d-45d1-9d2e-bab8b2ded94f", null, false, false, null, null, null, null, null, false, false, "7cc89f33-63e6-473a-8e45-8cfcecdd87e5", null, false, "Sirajuddin Asjad" },
                    { "337dff8b-00d8-49d3-9fda-c7404dd821f0", 0, null, "1500733a-00e5-4f77-9672-3f609a3a5fe6", null, false, false, null, null, null, null, null, false, true, "a992d031-e622-41d6-a4bb-7e5c5f344933", null, false, "Sirapudding" },
                    { "323a3361-2540-4d5d-8f3e-84f7d93344f0", 0, null, "46717bdd-9d22-444b-8f64-5b6a71d042f1", null, false, false, null, null, null, null, null, false, false, "27cebcf9-a978-4818-841a-a0b1668607aa", null, false, "Stian Håve" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "Description", "Icon", "Title" },
                values: new object[,]
                {
                    { 1, "This is a test!", "fas fa-code", "Test course" },
                    { 2, "This is a test!", "fas fa-cogs", "Another test" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1a010b8a-0994-4268-a567-796eba45de0b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "323a3361-2540-4d5d-8f3e-84f7d93344f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "337dff8b-00d8-49d3-9fda-c7404dd821f0");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ba49b1f1-6266-400f-9a3b-0c7292cc84f8", 0, null, "551c3df7-3196-4c6a-b9c3-ed8243985afb", null, false, false, null, null, null, null, null, false, false, "6eaa03f6-1755-4526-b2d6-44be6f910b9b", null, false, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "23c06d69-c85e-486a-9a1b-ea47d9f96bc8", 0, null, "e635c5dd-6b24-488f-846a-16d8b2fb846e", null, false, false, null, null, null, null, null, false, true, "f0c2eae4-dad8-46e8-a522-194c29fa6fc0", null, false, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1e8c3185-8baf-4020-9efe-3cbb892012d7", 0, null, "e8275ba4-00af-407c-8e28-ed898bb764e4", null, false, false, null, null, null, null, null, false, false, "41e37de4-2fd4-4e85-837b-3300af289f51", null, false, "Stian Håve" });
        }
    }
}
