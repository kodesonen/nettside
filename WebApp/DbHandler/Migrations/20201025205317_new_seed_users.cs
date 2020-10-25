using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class new_seed_users : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b02f7301-d5b1-430a-96d4-ee67c6ccce29", 0, null, "dc24ae31-2809-4800-8d32-e845a58d8519", null, false, false, null, null, null, null, null, false, "878f2cb4-e6a6-4ff3-94b2-7755ad2cadea", null, false, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e590507d-705b-4715-b218-7daeaf23172f", 0, null, "c20b2de6-95f0-48e4-ae23-0d7196e91bf5", null, false, false, null, null, null, null, null, false, "f0bfc74e-d364-4096-bd5f-39503ad845c6", null, false, "Stian Håve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b02f7301-d5b1-430a-96d4-ee67c6ccce29");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e590507d-705b-4715-b218-7daeaf23172f");
        }
    }
}
