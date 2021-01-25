using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class Heisannn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "c6e0e05e-c0c5-46c4-b87d-4a84c115aa81", 0, null, "f7f08441-31c4-4cff-9dad-2f5ba7b82856", "Dette er en beskrivelse!", null, false, null, null, false, null, null, null, null, null, false, false, "66f0003e-30b9-4b49-8c31-a5870e59eb35", "Systemansvarlig", "Masterstudent", false, "USN", "sirasjad", "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "392db5fb-b8a4-44db-ac1e-d1526f933242", 0, null, "ea3c9cea-3a45-4558-aae7-3c44e7846d13", null, null, false, null, null, false, null, null, null, null, null, false, true, "6da68f0d-0673-4cae-a252-a543de6fb5ae", null, null, false, null, null, "Sirapudding" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "de38cf77-382d-499d-8d85-a1a8f0baf08f", 0, null, "9c9333d5-c07c-4df4-8948-5076507191fe", null, null, false, null, null, false, null, null, null, null, null, false, false, "9787bca5-be42-459f-834b-c26960982a86", null, null, false, null, null, "Stian Håve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "392db5fb-b8a4-44db-ac1e-d1526f933242");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6e0e05e-c0c5-46c4-b87d-4a84c115aa81");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de38cf77-382d-499d-8d85-a1a8f0baf08f");

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
    }
}
