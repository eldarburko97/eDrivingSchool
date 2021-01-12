using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class PaymentNewColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Type",
                table: "Payments",
                newName: "Note");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfLessons",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Category",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "NumberOfLessons",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.RenameColumn(
                name: "Note",
                table: "Payments",
                newName: "Type");
        }
    }
}
