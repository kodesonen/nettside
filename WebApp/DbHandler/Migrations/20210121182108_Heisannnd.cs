using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApp.DbHandler.Migrations
{
    public partial class Heisannnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "50af68ab-378d-403d-ac69-5d90cb1cb8f9", 0, null, "2bdde3c6-cce0-46a4-a593-9619cd38ea36", "Dette er en beskrivelse!", null, false, "https://github.com/sirasjad", "https://www.linkedin.com/in/sirajuddin97", false, null, null, null, null, null, false, false, "35fad868-eb75-4b44-aa57-7cf484fb3751", "Systemansvarlig", "Masterstudent", false, "USN", "sirasjad", "Sirajuddin Asjad" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ApiKey", "ConcurrencyStamp", "Description", "Email", "EmailConfirmed", "GitHub", "LinkedIn", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Private", "SecurityStamp", "StaffPosition", "Study", "TwoFactorEnabled", "University", "UrlName", "UserName" },
                values: new object[] { "05cde3ee-b325-4e98-ac65-0303c6ec10bf", 0, null, "c94c2da4-836d-487d-a4f2-8b5612c5878d", null, null, false, null, null, false, null, null, null, null, null, false, false, "183fd6b9-6e9f-4ee1-a110-8fe083ef38fa", null, null, false, null, "stianh", "Stian Håve" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "05cde3ee-b325-4e98-ac65-0303c6ec10bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "50af68ab-378d-403d-ac69-5d90cb1cb8f9");

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
    }
}
