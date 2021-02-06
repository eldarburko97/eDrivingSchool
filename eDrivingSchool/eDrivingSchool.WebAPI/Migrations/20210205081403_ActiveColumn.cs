using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class ActiveColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "TheoryTestApplications");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "DrivingTestApplications");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "TheoryTestApplications",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "DrivingTestApplications",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "TheoryTestApplications");

            migrationBuilder.DropColumn(
                name: "Active",
                table: "DrivingTestApplications");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "TheoryTestApplications",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "DrivingTestApplications",
                nullable: false,
                defaultValue: 0);
        }
    }
}
