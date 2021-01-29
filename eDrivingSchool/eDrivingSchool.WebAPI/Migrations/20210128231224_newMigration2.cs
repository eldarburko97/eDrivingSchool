using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class newMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Payments",
                newName: "Instructor_Category_CandidateId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_UserId",
                table: "Payments",
                newName: "IX_Payments_Instructor_Category_CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "Payments",
                column: "Instructor_Category_CandidateId",
                principalTable: "Instructors_Categories_Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "Payments");

            migrationBuilder.RenameColumn(
                name: "Instructor_Category_CandidateId",
                table: "Payments",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_Instructor_Category_CandidateId",
                table: "Payments",
                newName: "IX_Payments_UserId");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Payments",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_UserId",
                table: "Payments",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
