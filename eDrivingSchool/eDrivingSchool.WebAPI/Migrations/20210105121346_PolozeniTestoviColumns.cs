using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class PolozeniTestoviColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Polozio",
                table: "Instructors_Categories_Candidates",
                newName: "PolozenTestPrvePomoci");

            migrationBuilder.AddColumn<bool>(
                name: "PolozenPrakticniTest",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "PolozenTeorijskiTest",
                table: "Instructors_Categories_Candidates",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PolozenPrakticniTest",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.DropColumn(
                name: "PolozenTeorijskiTest",
                table: "Instructors_Categories_Candidates");

            migrationBuilder.RenameColumn(
                name: "PolozenTestPrvePomoci",
                table: "Instructors_Categories_Candidates",
                newName: "Polozio");
        }
    }
}
