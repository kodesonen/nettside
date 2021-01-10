using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class newmods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4bdcc0b0-bae0-40ce-81f1-7a9196a061cf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8b149e65-09e2-426b-b201-af9527426340");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8ab0be0-d396-4499-bdf2-9efcf28388cd");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "a954fed0-ded6-4ffd-b582-957824cf06e6", 0, null, "ccfba14f-f918-4202-bc0d-8330da173b3d", null, false, false, null, null, null, null, null, false, false, "0cb71166-1b96-4e83-a595-768ed350034b", null, false, "Sirajuddin Asjad" },
                    { "00e32a44-e641-4be7-855b-410e62bdf3cd", 0, null, "e1b00b51-1494-4232-84a1-b7763bcfb2d9", null, false, false, null, null, null, null, null, false, true, "d3f0569d-1c8e-4388-9ff7-9015158d48a1", null, false, "Sirapudding" },
                    { "d279f086-9c39-4a12-8eac-a75515c05ee6", 0, null, "f13d99a3-de10-4738-9a40-881f74107f8a", null, false, false, null, null, null, null, null, false, false, "5adef5ce-8828-43b8-bfb7-35e14661ed98", null, false, "Stian Håve" }
                });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "Chapter", "CourseId", "Name", "SubChapter" },
                values: new object[,]
                {
                    { 1, 1, 1, "Test module", 1 },
                    { 2, 1, 1, "Another module", 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00e32a44-e641-4be7-855b-410e62bdf3cd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a954fed0-ded6-4ffd-b582-957824cf06e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d279f086-9c39-4a12-8eac-a75515c05ee6");

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Modules",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8b149e65-09e2-426b-b201-af9527426340", 0, null, "46481883-f1f2-41f8-89dc-9f7392eccd14", null, false, false, null, null, null, null, null, false, false, "57ce8c60-a277-41a2-b780-7a846dca681c", null, false, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b8ab0be0-d396-4499-bdf2-9efcf28388cd", 0, null, "50de7b53-4033-41c4-8ddc-757a9d715c90", null, false, false, null, null, null, null, null, false, true, "858bc348-1830-49b8-a8bd-9a271af97b94", null, false, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4bdcc0b0-bae0-40ce-81f1-7a9196a061cf", 0, null, "c0855d34-1628-47be-bf61-35ee5c4be06f", null, false, false, null, null, null, null, null, false, false, "53a849da-d1cc-4c80-a54b-7bff7beea2df", null, false, "Stian Håve" });
        }
    }
}
