using Microsoft.EntityFrameworkCore.Migrations;

namespace eDrivingSchool.WebAPI.Migrations
{
    public partial class TheoryTestApplicationsFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_TheoryTestApplications_Instructor_Category_CandidateId",
                table: "TheoryTestApplications",
                column: "Instructor_Category_CandidateId");

            migrationBuilder.AddForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "TheoryTestApplications",
                column: "Instructor_Category_CandidateId",
                principalTable: "Instructors_Categories_Candidates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TheoryTestApplications_Instructors_Categories_Candidates_Instructor_Category_CandidateId",
                table: "TheoryTestApplications");

            migrationBuilder.DropIndex(
                name: "IX_TheoryTestApplications_Instructor_Category_CandidateId",
                table: "TheoryTestApplications");
        }
    }
}
