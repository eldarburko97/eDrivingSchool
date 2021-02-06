using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class NewRelationShip : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLessons_Users_InstructorId",
                table: "DrivingLessons");

            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLessons_Users_UserId",
                table: "DrivingLessons");

            migrationBuilder.DropIndex(
                name: "IX_DrivingLessons_InstructorId",
                table: "DrivingLessons");

            migrationBuilder.DropIndex(
                name: "IX_DrivingLessons_UserId",
                table: "DrivingLessons");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "DrivingLessons",
                newName: "CategoryId");

            migrationBuilder.AddColumn<int>(
                name: "CandidateId",
                table: "DrivingLessons",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_InstructorId_CategoryId_CandidateId",
                table: "DrivingLessons",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" });

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLessons_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "DrivingLessons",
                columns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                principalTable: "Instructors_Categories_Candidates",
                principalColumns: new[] { "InstructorId", "CategoryId", "CandidateId" },
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DrivingLessons_Instructors_Categories_Candidates_InstructorId_CategoryId_CandidateId",
                table: "DrivingLessons");

            migrationBuilder.DropIndex(
                name: "IX_DrivingLessons_InstructorId_CategoryId_CandidateId",
                table: "DrivingLessons");

            migrationBuilder.DropColumn(
                name: "CandidateId",
                table: "DrivingLessons");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "DrivingLessons",
                newName: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_InstructorId",
                table: "DrivingLessons",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_DrivingLessons_UserId",
                table: "DrivingLessons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLessons_Users_InstructorId",
                table: "DrivingLessons",
                column: "InstructorId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DrivingLessons_Users_UserId",
                table: "DrivingLessons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
