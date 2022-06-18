using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WinFormsApp2.Migrations
{
    public partial class Update_Students_AddAvatar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Students",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Students");
        }
    }
}
