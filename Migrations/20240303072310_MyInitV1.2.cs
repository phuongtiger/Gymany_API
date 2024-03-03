using Microsoft.EntityFrameworkCore.Migrations;

namespace Gymany_API.Migrations
{
    public partial class MyInitV12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "PersonalTrainers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Phone",
                table: "PersonalTrainers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "PersonalTrainers");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "PersonalTrainers");
        }
    }
}
