using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogWebApp.Data.Migrations
{
    public partial class UserRestrictions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Post",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Comment",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Comment");
        }
    }
}
