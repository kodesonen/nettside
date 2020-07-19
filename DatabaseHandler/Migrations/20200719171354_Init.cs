using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DatabaseHandler.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    Study = table.Column<string>(nullable: true),
                    Degree = table.Column<string>(nullable: true),
                    Admin = table.Column<int>(nullable: false),
                    Hidden = table.Column<bool>(nullable: false),
                    RegDate = table.Column<int>(nullable: false),
                    LastLogin = table.Column<string>(nullable: true),
                    ImageUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Admin", "Degree", "Email", "FirstName", "Hidden", "ImageUrl", "LastLogin", "LastName", "Password", "RegDate", "Study" },
                values: new object[] { 2, 0, null, "sira@siratech.no", "Sirajuddin", false, null, null, "Asjad", null, 0, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
