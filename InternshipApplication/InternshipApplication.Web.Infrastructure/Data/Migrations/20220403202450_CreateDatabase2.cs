using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternshipApplication.Web.Infrastructure.Data.Migrations
{
    public partial class CreateDatabase2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Products",
                newName: "ImagePaths");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePaths",
                table: "Products",
                newName: "ImagePath");
        }
    }
}
