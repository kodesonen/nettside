using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class ProfileBackend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "TestColumn",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GitHub",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedIn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "StaffPosition",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Study",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UserName" },
                values: new object[] { "7605339b-74cf-42b4-a2b1-10f7df1b6841", 0, null, "6d6b4c47-d6cc-45b5-8760-8d72dcabde5b", null, null, false, null, null, false, null, null, null, null, null, false, false, "c20a77fe-e85f-414f-a3aa-cf9eb010c10c", null, null, false, null, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UserName" },
                values: new object[] { "5999c4a3-d16d-4d38-ad2b-a76f3a77e4e9", 0, null, "3c5d6bfa-8103-4ae0-883f-d32986f0bedf", null, null, false, null, null, false, null, null, null, null, null, false, true, "d19375ea-229d-4e02-9490-940442f5b359", null, null, false, null, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UserName" },
                values: new object[] { "22ce0c9d-e77b-4d53-b0d2-03549a0dbfe2", 0, null, "88f20065-6014-4b72-88a9-c02a1ab65b8b", null, null, false, null, null, false, null, null, null, null, null, false, false, "a68fbc1a-4126-43ee-a61f-6a1bace2fd70", null, null, false, null, "Stian Håve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "22ce0c9d-e77b-4d53-b0d2-03549a0dbfe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5999c4a3-d16d-4d38-ad2b-a76f3a77e4e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7605339b-74cf-42b4-a2b1-10f7df1b6841");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "GitHub",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LinkedIn",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "StaffPosition",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Study",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "University",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "TestColumn",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a954fed0-ded6-4ffd-b582-957824cf06e6", 0, null, "ccfba14f-f918-4202-bc0d-8330da173b3d", null, false, false, null, null, null, null, null, false, false, "0cb71166-1b96-4e83-a595-768ed350034b", null, false, "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "00e32a44-e641-4be7-855b-410e62bdf3cd", 0, null, "e1b00b51-1494-4232-84a1-b7763bcfb2d9", null, false, false, null, null, null, null, null, false, true, "d3f0569d-1c8e-4388-9ff7-9015158d48a1", null, false, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "TestColumn", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d279f086-9c39-4a12-8eac-a75515c05ee6", 0, null, "f13d99a3-de10-4738-9a40-881f74107f8a", null, false, false, null, null, null, null, null, false, false, "5adef5ce-8828-43b8-bfb7-35e14661ed98", null, false, "Stian Håve" });
        }
    }
}
