using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class PassedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Passed",
                table: "DrivingTestApplications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Passed",
                table: "DrivingTestApplications");
        }
    }
}
