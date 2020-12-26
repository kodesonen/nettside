using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class latestt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Courses",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b6507e77-8031-447a-993f-70bbf6506e4c", 0, null, "f1eb1765-e2f5-43ce-97d6-cfa4d8ca7f29", null, false, false, null, null, null, null, null, false, false, "193cff24-be4b-4ab2-9cf7-4953f0f36e64", null, false, "Sirajuddin Asjad" },
                    { "02acb44a-fc01-4105-9a82-8b9dc0917c7c", 0, null, "f890f62a-2a4c-4f25-bc45-e457c8e5c0d7", null, false, false, null, null, null, null, null, false, true, "db7f35ef-0b66-440b-8050-3e0ffb71e541", null, false, "Sirapudding" },
                    { "070b33bd-8269-4804-8c1b-203942bd92d0", 0, null, "105d9642-2772-471c-838e-b13022c87da7", null, false, false, null, null, null, null, null, false, false, "ef296c2b-40da-42cf-be78-b0815fcd835d", null, false, "Stian Håve" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Test course");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Another test");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02acb44a-fc01-4105-9a82-8b9dc0917c7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "070b33bd-8269-4804-8c1b-203942bd92d0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6507e77-8031-447a-993f-70bbf6506e4c");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Courses");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Courses",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1a010b8a-0994-4268-a567-796eba45de0b", 0, null, "edd9121c-878d-45d1-9d2e-bab8b2ded94f", null, false, false, null, null, null, null, null, false, false, "7cc89f33-63e6-473a-8e45-8cfcecdd87e5", null, false, "Sirajuddin Asjad" },
                    { "337dff8b-00d8-49d3-9fda-c7404dd821f0", 0, null, "1500733a-00e5-4f77-9672-3f609a3a5fe6", null, false, false, null, null, null, null, null, false, true, "a992d031-e622-41d6-a4bb-7e5c5f344933", null, false, "Sirapudding" },
                    { "323a3361-2540-4d5d-8f3e-84f7d93344f0", 0, null, "46717bdd-9d22-444b-8f64-5b6a71d042f1", null, false, false, null, null, null, null, null, false, false, "27cebcf9-a978-4818-841a-a0b1668607aa", null, false, "Stian Håve" }
                });

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "Test course");

            migrationBuilder.UpdateData(
                table: "Courses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Another test");
        }
    }
}
