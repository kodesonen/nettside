using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class latest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b02f7301-d5b1-430a-96d4-ee67c6ccce29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e590507d-705b-4715-b218-7daeaf23172f");

            migrationBuilder.AddColumn<bool>(
                name: "Private",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: false);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Private",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b02f7301-d5b1-430a-96d4-ee67c6ccce29", 0, null, "dc24ae31-2809-4800-8d32-e845a58d8519", null, false, false, null, null, null, null, null, false, "878f2cb4-e6a6-4ff3-94b2-7755ad2cadea", null, false, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e590507d-705b-4715-b218-7daeaf23172f", 0, null, "c20b2de6-95f0-48e4-ae23-0d7196e91bf5", null, false, false, null, null, null, null, null, false, "f0bfc74e-d364-4096-bd5f-39503ad845c6", null, false, "Stian Håve" });
        }
    }
}
