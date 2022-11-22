using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UpSchool.DataAccessLayer.Migrations
{
    public partial class create_migration_announcement : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "EmployeeTasks");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "EmployeeTasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Announcements",
                columns: table => new
                {
                    AnnouncementID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnnouncementTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AnnouncementDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Announcements", x => x.AnnouncementID);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks");

            migrationBuilder.DropTable(
                name: "Announcements");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "EmployeeTasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "EmployeeTasks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeTasks_AspNetUsers_AppUserId",
                table: "EmployeeTasks",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
