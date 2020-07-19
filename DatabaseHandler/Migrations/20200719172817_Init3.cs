using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHandler.Migrations
{
    public partial class Init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Admin", "Email", "FirstName", "LastName" },
                values: new object[] { true, "danskry@outlook.com", "Daniel", "Skryseth" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Admin", "Degree", "Email", "FirstName", "Hidden", "ImageUrl", "LastLogin", "LastName", "Password", "RegDate", "Study" },
                values: new object[] { 1, true, null, "sira@siratech.no", "Sirajuddin", false, null, null, "Asjad", null, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Admin", "Email", "FirstName", "LastName" },
                values: new object[] { false, "sira@siratech.no", "Sirajuddin", "Asjad" });
        }
    }
}
