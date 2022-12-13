using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool.DataAccessLayer.Migrations
{
    public partial class mig_login_character : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LoginCharacter",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LoginCharacter",
                table: "AspNetUsers");
        }
    }
}
