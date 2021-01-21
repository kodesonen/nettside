using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class Heisann : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "UrlName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "4e848069-393c-4905-b3a6-ac80fc6f036b", 0, null, "4b4dd2ab-52e6-4d1a-a3af-68366d0020d3", null, null, false, null, null, false, null, null, null, null, null, false, false, "a2e7cdda-e213-4d52-91c6-873302272df3", null, null, false, null, "sirasjad", "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "1954535f-e36e-4461-b61c-16853e497b50", 0, null, "e29b8c6a-796a-430c-9939-8c60fdb66a9c", null, null, false, null, null, false, null, null, null, null, null, false, true, "4aa0c125-c01d-4f24-948d-07a4c83c694c", null, null, false, null, null, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "adb40877-94bb-4d5c-a09a-68a50af220f8", 0, null, "1de79930-0fa2-4cd8-a88f-17ce9eb1209a", null, null, false, null, null, false, null, null, null, null, null, false, false, "d4a49359-e023-4396-868d-6a5022188635", null, null, false, null, null, "Stian Håve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1954535f-e36e-4461-b61c-16853e497b50");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e848069-393c-4905-b3a6-ac80fc6f036b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "adb40877-94bb-4d5c-a09a-68a50af220f8");

            migrationBuilder.DropColumn(
                name: "UrlName",
                table: "AspNetUsers");

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
    }
}
