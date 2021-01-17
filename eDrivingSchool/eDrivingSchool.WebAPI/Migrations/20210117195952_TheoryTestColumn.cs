using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class TheoryTestColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "TheoryTest",
                table: "TheoryTestApplications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TheoryTest",
                table: "TheoryTestApplications");
        }
    }
}
